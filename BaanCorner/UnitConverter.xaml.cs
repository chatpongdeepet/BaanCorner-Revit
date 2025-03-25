using System.Collections.Generic;
using System.Linq;
using System.Windows;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using BaanCorner.Services;
using System.IO;
using Microsoft.Win32;



namespace UnitConverter
{
    public partial class MainWindow : Window
    {
        private readonly Document _doc;

        public MainWindow(Document doc)
        {
            InitializeComponent();
            _doc = doc;

            // Load Units into DataGrid
            CommonDataGrid.ItemsSource = PopulateGrid(doc, "Common");
        }

        // Class for Unit information
        public class Unit
        {
            public string UnitName { get; set; }
            public List<string> FormatOptions { get; set; }
            public string SelectedFormat { get; set; }
        }

        private List<Unit> PopulateGrid(Document doc, string discipline)
        {
            var units = new List<Unit>();
            var projectUnits = doc.GetUnits();

            if (discipline == "Common")
            {
                var unitNames = new List<string>
                {
                    "Angle", "Area", "Cost per Area", "Length", "Distance",
                    "Mass Density", "Rotation Angle", "Slope", "Speed",
                    "Time", "Volume"
                };

                foreach (var unitName in unitNames)
                {
                    if (UnitFormats.UnitNameToSpec.TryGetValue(unitName, out var spec))
                    {
                        units.Add(new Unit
                        {
                            UnitName = unitName,
                            FormatOptions = UnitService.GetUnitFormats(projectUnits, spec),
                            SelectedFormat = UnitService.GetSelectedFormat(projectUnits, spec)
                        });
                    }
                }
            }

            return units;
        }

        private void ApplyButton_Click(object sender, RoutedEventArgs e)
        {
            if (CommonDataGrid.ItemsSource is List<Unit> updatedUnits)
            {
                UpdateProjectUnits(updatedUnits);
                MessageBox.Show("Project Units Updated Successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void UpdateProjectUnits(List<Unit> updatedUnits)
        {
            using var transaction = new Transaction(_doc, "Update Project Units");
            transaction.Start();

            var projectUnits = _doc.GetUnits();

            foreach (var unit in updatedUnits)
            {
                if (UnitFormats.UnitNameToSpec.TryGetValue(unit.UnitName, out var spec))
                {
                    var formatOptions = projectUnits.GetFormatOptions(spec);
                    formatOptions.SetUnitTypeId(unit.SelectedFormat switch
                    {
                        "Meters" => UnitTypeId.Meters,
                        "Millimeters" => UnitTypeId.Millimeters,
                        "Feet" => UnitTypeId.Feet,
                        _ => formatOptions.GetUnitTypeId()
                    });

                    projectUnits.SetFormatOptions(spec, formatOptions);
                }
            }

            _doc.SetUnits(projectUnits);
            transaction.Commit();
        }

        private void ExportProjectUnits()
        {
            // เปิด SaveFileDialog เพื่อเลือกที่บันทึกไฟล์
            var saveFileDialog = new SaveFileDialog
            {
                Filter = "Text Files (*.txt)|*.txt",
                DefaultExt = ".txt",
                Title = "Export Project Units"
            };

            if (saveFileDialog.ShowDialog() == true) // ถ้าผู้ใช้กด Save
            {
                var filePath = saveFileDialog.FileName;

                // ดึง Project Units
                var projectUnits = _doc.GetUnits();
                var unitExportData = new List<string>();
                
                IList<ForgeTypeId> specs = Units.GetModifiableSpecs();

                foreach (var spec in specs)
                {
                    // ดึงข้อมูล Unit Format
                    var selectedFormat = UnitService.GetSelectedFormat(projectUnits, spec);
                    var formatOptions = UnitService.GetUnitFormats(projectUnits, spec);

                    // บันทึกข้อมูลลงในไฟล์ (SpecTypeId:SelectedFormat:FormatOptions)
                    unitExportData.Add($"{spec.TypeId}:{selectedFormat}:{string.Join(",", formatOptions)}");
                }

                // บันทึกลงไฟล์ .txt
                File.WriteAllLines(filePath, unitExportData);
                MessageBox.Show("Export Completed!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void ImportProjectUnits()
        {
            // เปิด OpenFileDialog ให้ผู้ใช้เลือกไฟล์
            var openFileDialog = new OpenFileDialog
            {
                Filter = "Text Files (*.txt)|*.txt",
                DefaultExt = ".txt",
                Title = "Import Project Units"
            };

            if (openFileDialog.ShowDialog() == true) // ถ้าผู้ใช้เลือกไฟล์
            {
                var filePath = openFileDialog.FileName;

                if (!File.Exists(filePath))
                {
                    MessageBox.Show("File not found!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                try
                {
                    // อ่านข้อมูลจากไฟล์ .txt
                    var lines = File.ReadAllLines(filePath);
                    var updatedUnits = new Dictionary<ForgeTypeId, string>();

                    foreach (var line in lines)
                    {
                        var parts = line.Split(':'); // ข้อมูลแยกด้วย :
                        if (parts.Length >= 2)
                        {
                            var typeId = parts[0];
                            var selectedFormat = parts[2]; // ค่า selectedFormat จากไฟล์ (column 3)

                            // สร้าง ForgeTypeId จาก typeId
                            var spec = new ForgeTypeId(typeId);

                            // ตรวจสอบว่าค่า spec สามารถวัดผลได้ (Measurable)
                            if (UnitUtils.IsMeasurableSpec(spec))
                            {
                                updatedUnits[spec] = selectedFormat;
                            }
                            else
                            {
                                Console.WriteLine($"The specTypeId '{spec.TypeId}' is not measurable.");
                            }
                        }
                    }

                    // เริ่มต้นการอัปเดต Project Units
                    using var transaction = new Transaction(_doc, "Update Project Units");
                    transaction.Start();

                    var projectUnits = _doc.GetUnits();

                    foreach (var entry in updatedUnits)
                    {
                        var spec = entry.Key; // เข้าถึง Key
                        var selectedFormat = entry.Value; // Format ที่ต้อง Mapping

                        // Map selectedFormat เข้ากับ UnitTypeId
                        UnitTypeId newUnitTypeId = MapSelectedFormatToUnitTypeId(selectedFormat);

                        // ถ้า mapping สำเร็จ ให้อัปเดต FormatOptions
                        if (newUnitTypeId != null)
                        {
                            var formatOptions = projectUnits.GetFormatOptions(spec);
                            formatOptions.SetUnitTypeId(newUnitTypeId);
                            projectUnits.SetFormatOptions(spec, formatOptions);
                        }
                        else
                        {
                            Console.WriteLine(
                                $"Cannot map selectedFormat '{selectedFormat}' for spec '{spec.TypeId}'.");
                        }
                    }

                    _doc.SetUnits(projectUnits);
                    transaction.Commit();

                    MessageBox.Show("Import Completed and Units Updated!", "Success", MessageBoxButton.OK,
                        MessageBoxImage.Information);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error during import: {ex.Message}");
                    MessageBox.Show($"Error during import: {ex.Message}", "Error", MessageBoxButton.OK,
                        MessageBoxImage.Error);
                }
            }
            
        }

        private UnitTypeId MapSelectedFormatToUnitTypeId(string selectedFormat)
        {
            return selectedFormat switch
            {
                "Fractional inches" => UnitTypeId.InchesFractional,
                "Meters" => UnitTypeId.Meters,
                "Millimeters" => UnitTypeId.Millimeters,
                // เพิ่มค่า mapping ตามที่ต้องการ
                "Feet" => UnitTypeId.Feet,
                _ => null // กรณี selectedFormat ไม่ตรงกับ UnitTypeId ที่รู้จัก
            };
        }





        private void ExportButton_Click(object sender, RoutedEventArgs e)
        {
            ExportProjectUnits();
        }

        private void ImportButton_Click(object sender, RoutedEventArgs e)
        {
            ImportProjectUnits();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e) => Close();
    }
}