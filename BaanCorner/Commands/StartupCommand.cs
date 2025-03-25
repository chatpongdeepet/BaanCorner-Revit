using Autodesk.Revit.Attributes;
using Nice3point.Revit.Toolkit.External;
using Autodesk.Revit.UI;

namespace BaanCorner.Commands;

[UsedImplicitly]
[Transaction(TransactionMode.Manual)]
public class StartupCommand : ExternalCommand
{
    public override void Execute()
    {
        // ดึงเอกสาร Revit ที่กำลังเปิดใช้งาน
        var doc = ActiveView.Document;

        // สร้าง Transaction สำหรับการเปลี่ยนแปลง
        using var transaction = new Transaction(doc, "Update Length Unit to Meters");

        try
        {
            transaction.Start();

            // ดึง Units ปัจจุบัน
            var units = doc.GetUnits();

            // ดึง FormatOptions ของ Length
            var lengthFormatOptions = units.GetFormatOptions(SpecTypeId.Length);
            

            // กำหนด UnitTypeId ใหม่เป็น Meters
            lengthFormatOptions.SetUnitTypeId(UnitTypeId.FeetFractionalInches);

            // ตั้งค่า FormatOptions กลับไปที่ Units
            units.SetFormatOptions(SpecTypeId.Length, lengthFormatOptions);

            // บันทึกการอัปเดต Units
            doc.SetUnits(units);

            transaction.Commit();

            TaskDialog.Show("Success", "Length Unit has been updated to Meters.");
        }
        catch (Exception ex)
        {
            transaction.RollBack();
            TaskDialog.Show("Error", $"An error occurred: {ex.Message}");
        }


    }
}