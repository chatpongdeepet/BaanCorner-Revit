using Autodesk.Revit.Attributes;
using Nice3point.Revit.Toolkit.External;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System.Collections.Generic;
using System.Text;

namespace BaanCorner.Commands;

[UsedImplicitly]
[Transaction(TransactionMode.Manual)]
public class LoadProjectUnitsCommand : ExternalCommand
{
    public override void Execute()
    {

        var doc = ActiveView.Document;

        if (!doc.IsValidObject)
        {
            TaskDialog.Show("Error", "Document is not valid or unavailable.");
            return;
        }

        var units = doc.GetUnits();

        StringBuilder infoBuilder = new StringBuilder();

        IList<ForgeTypeId> specs = Units.GetModifiableSpecs();
        
        var formatOptionsTest = doc.GetUnits().GetFormatOptions(SpecTypeId.Length);
        var typeId = formatOptionsTest.GetUnitTypeId().TypeId;

        var angleFormats = GetAvailableUnitFormats(units, SpecTypeId.HvacPressure);
        
        
            
        foreach (var format in angleFormats)
        {
            TaskDialog.Show("Length Format", format);
        }
        
    }
    
    private List<string> GetAvailableUnitFormats(Units projectUnits, ForgeTypeId spec)
    {
        var formatOptions = projectUnits.GetFormatOptions(spec);
        var availableFormats = new List<string>();

        // ดึงข้อมูล UnitTypeId ตาม Spec ที่สนใจ
        var typeId = formatOptions.GetUnitTypeId();

        // ตรวจสอบหน่วยที่เกี่ยวข้องทั้งหมด
        var unitTypeId = typeId.TypeId;

        // (Optional) Show ให้ดูผลลัพธ์ว่าทั้งหมดคืออะไร

        // ดึงชื่อระหว่าง ":" และ "-" และเพิ่มลงใน list
        int start = unitTypeId.IndexOf(':') + 1;
        int end = unitTypeId.IndexOf('-');
        string availableFormat = unitTypeId.Substring(start, end - start);

        availableFormats.Add(availableFormat);

        return availableFormats;
    }

    
}