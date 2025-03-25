using Autodesk.Revit.Attributes;
using Nice3point.Revit.Toolkit.External;
using UnitConverter;

namespace BaanCorner.Commands;

[UsedImplicitly]
[Transaction(TransactionMode.Manual)]
public class SaveProjectUnitsCommand : ExternalCommand
{
    public override void Execute()
    {
        var doc = ActiveView.Document;

        var units = doc.GetUnits();

        
        
        // เปิดหน้าต่าง UnitConverter.xaml
        var unitConverterWindow = new MainWindow(doc);
        
        // ตั้งค่าหน้าต่าง WPF ให้เปิดเหนือ Revit (Topmost)
        unitConverterWindow.Topmost = true;

        // แสดงหน้าต่างแบบ Modal Dialog เพื่อให้ Revit โฟกัสที่หน้าต่างนี้
        unitConverterWindow.ShowDialog();
    }
}