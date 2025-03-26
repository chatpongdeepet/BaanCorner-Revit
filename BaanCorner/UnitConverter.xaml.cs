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
            ElectricalDataGrid.ItemsSource = PopulateGrid(doc, "Electrical");
            EnergyDataGrid.ItemsSource = PopulateGrid(doc, "Energy");
            HVACDataGrid.ItemsSource = PopulateGrid(doc, "HVAC");
            InfrastructureDataGrid.ItemsSource = PopulateGrid(doc, "Infrastructure");
            PipingDataGrid.ItemsSource = PopulateGrid(doc, "Piping");
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

            if (discipline == "Electrical")
            {
                var unitNames = new List<string>
                {
                    "Apparent Power",
                    "Apparent Power Density",
                    "Cable Tray Size",
                    "Color Temperature",
                    "Conduit Size",
                    "Cost Rate Energy",
                    "Cost Rate Power",
                    "Current",
                    "Demand Factor",
                    "Efficacy",
                    "Frequency",
                    "Illuminance",
                    "Luminance",
                    "Luminous Flux",
                    "Luminous Intensity",
                    "Electrical Potential",
                    "Power",
                    "Power Density",
                    "Power per Length",
                    "Electrical Resistivity",
                    "Temperature",
                    "Wattage",
                    "Wire Diameter",
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
            
            if (discipline == "Energy")
            {
                var unitNames = new List<string>
                {
                   "Energy",
                   "Heat Capacity per Area",
                   "Coefficient of Heat Transfer",
                   "Isothermal Moisture Capacity",
                   "Permeability",
                   "Specific Heat",
                   "Specific Heat of Vaporization",
                   "Thermal gradient Coefficient",
                   "Thermal Mass",
                   "Thermal Resistance"
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
            if (discipline == "HVAC")
            {
                var unitNames = new List<string>
                {
                    "Air Flow",
                    "Air Flow Density",
                    "Air Flow divided by Cooling",
                    "Air Flow divided by Volume",
                    "Angular Speed",
                    "Area divided by Cooling Load",
                    "Area divided by Heating Load",
                    "Cooling Load",
                    "Cooling Load divided by Area",
                    "Cooling Load divided by Volumn",
                    "Cross Section",
                    "HVAC Density",
                    "Diffusivity",
                    "Duct Insulation Thickness",
                    "Duct Lining Thickness",
                    "Duct Size",
                    "Factor",
                    "Flow per Power",
                    "Friction",
                    "Heat Gain",
                    "Heating Load",
                    "Heating Load divided by Area",
                    "Heating Load divided by Volumne",
                    "Mass per Time",
                    "HVAC Power",
                    "HVAC Power Density",
                    "Power per Flow",
                    "HVAC Pressure",
                    "Roughness",
                    "HVAC Slope",
                    "HVAC Temperature",
                    "HVAC Velocity",
                    "Dynamic Viscosity"
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
            
            if (discipline == "Infrastructure")
            {
                var unitNames = new List<string>
                {
                    "Stationing"
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
            
            if (discipline == "Piping")
            {
                var unitNames = new List<string>
                {
                    "Piping Density", "Flow", "Piping Friction",
                    "Piping Mass per Time", "Pipe Dimension",
                    "Pipe Insulation Thickness", "Pipe Mass per Unit Lenght",
                    "Pipe Size", "Pipe Pressure", "Pipe Roughness",
                    "Pipe Slope", "Pipe Temperature", "Pipe Velocity",
                    "Pipe Dynamic Viscosity", "Pipe Volume"
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
        


        private void ExportButton_Click(object sender, RoutedEventArgs e)
        {
            ExportProjectUnits();
        }

        private void ImportButton_Click(object sender, RoutedEventArgs e)
        {
            // ImportProjectUnits();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e) => Close();
    }
}