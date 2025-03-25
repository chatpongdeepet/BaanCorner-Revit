namespace BaanCorner.Services
{
    public static class UnitService
    {
        public static List<string> GetUnitFormats(Units projectUnits, ForgeTypeId spec)
        {
            if (UnitFormats.FormatMapping.TryGetValue(spec, out var availableFormats))
            {
                return availableFormats
                    .Where(s => !string.IsNullOrEmpty(s))
                    .Distinct()
                    .ToList();
            }

            return new List<string>();
        }

        public static string GetSelectedFormat(Units projectUnits, ForgeTypeId spec)
        {
            var formatOption = projectUnits.GetFormatOptions(spec);
            var typeId = formatOption.GetUnitTypeId().TypeId;

            string input = typeId;
            int start = input.IndexOf(":") + 1;
            int end = input.IndexOf("-");

            string result = input.Substring(start, end - start);

            // Mapping Display Text
            return result switch
            {
                "degrees" => "Degrees",
                "radians" => "Radians",
                "gradians" => "Gradians",
                "squareMeters" => "Square meters",
                "squareFeet" => "Square feet",
                "hectares" => "Hectares",
                "acres" => "Acres",
                "currencyPerSquareFoot" => "Cost per square foot",
                "currencyPerSquareMeter" => "Cost per square meter",
                "centimeters" => "Centimeters", 
                "decimeters" => "Decimeters", 
                "inches" => "Inches", 
                "USSurveyFeet" => "US survey feet",
                "meters" => "Meters",
                "millimeters" => "Millimeters",
                "feet" => "Feet",
                "feetFractionalInches" => "Feet fractional inches",
                "fractionalInches" => "Fractional inches", 
                "metersCentimeters" => "Meter and centimeters",
                "kilogramsPerCubicMeter" => "Kilograms per cubic meter", 
                "poundsMassPerCubicFoot" => "Pounds mass per cubic foot",
                "pi" => "Number of n",
                "1ToRatio" => "1 : Ratio",
                "perMile" => "Per mile", 
                "percentage" => "Percentage", 
                "ratioTo1" => "Ratio : 1", 
                "ratioTo10" => "Ratio : 10",
                "ratioTo12" => "Ratio : 12",
                "riseDividedBy1000Millimeters" => "Rise / 1000 millimeters", 
                "riseDividedBy10Feet" => "Rise / 10 feet", 
                "riseDividedBy120Inches" => "Rise / 120 inches", 
                "riseDividedBy12Inches" => "Rise / 12 inches", 
                "riseDividedBy1Foot" => "Rise /1 foot", 
                "slopeDegrees" => "Degrees",
                "centimetersPerMinute" => "Centimeters per minute",
                "feetPerMinute" => "Feet per minute",
                "feetPerSecond" => "Feet per second",
                "kilometersPerHour" => "Kilometers per hour",
                "metersPerSecond" => "Meters per second",
                "milesPerHour" => "Miles per hour",
                "hours" => "Hours",
                "milliseconds" => "Milliseconds", 
                "minutes" => "Minute", 
                "seconds" => "Seconds",
                "cubicCentimeters" => "Cubic centimeters", 
                "cubicFeet" => "Cubic feet", 
                "cubicInches" => "Cubic inches", 
                "cubicMeters" => "Cubic meters", 
                "cubicMillimeters" => "Cubic millimeters", 
                "cubicYards" => "Cubic yards", 
                "liters" => "Liters", 
                "usGallons" => "US gallons",
                _ => "Unknown"
            };
        }
    }
}