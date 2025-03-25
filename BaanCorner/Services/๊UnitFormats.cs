namespace BaanCorner.Services
{
    public static class UnitFormats
    {
        // Mapping between ForgeTypeId and format options
        public static readonly Dictionary<ForgeTypeId, List<string>> FormatMapping = new()
        {
            {
                SpecTypeId.Angle, new List<string>
                {
                    "Degrees", "Radians", "Radians"
                }
            },
            {
                SpecTypeId.Area, new List<string>
                {
                    "Square meters", "Square feet", "Hectares", "Acres"
                }
            },
            {
            SpecTypeId.CostPerArea, new List<string>
                {
                "Cost per square foot", "Cost per square meter"
                }
            },
            {
                SpecTypeId.Distance, new List<string>
                {
                    "Centimeters", "Decimeters", "Feet", "Inches", "Meters", "Millimeters", "US survey feet",
                }
            },
            {
                SpecTypeId.Length, new List<string>
                {
                    "Centimeters", "Decimeters", "Feet", "Inches", "Meters", "Millimeters", "US survey feet", "Feet fractional inches", "Fractional inches", "Meter and centimeters"
                }
            },
            {
                SpecTypeId.MassDensity, new List<string>
                {
                    "Kilograms per cubic meter", "Pounds mass per cubic foot"
                }
            },
            {
                SpecTypeId.RotationAngle, new List<string>
                {
                    "Degrees", "Gradians", "Number of n", "Radians"
                }
            },
            {
                SpecTypeId.Slope, new List<string>
                {
                    "1 : Ratio", 
                    "Per mile", 
                    "Percentage", 
                    "Ratio : 1", 
                    "Ratio : 10", 
                    "Ratio : 12", 
                    "Rise / 1000 millimeters", 
                    "Rise / 10 feet", 
                    "Rise / 120 inches", 
                    "Rise / 12 inches", 
                    "Rise / 1 foot", 
                    "Degrees"  
                }
            },
            {
                SpecTypeId.Speed, new List<string>
                {
                    "Centimeter per minute", "Feet per minute", "Feet per second", "Kilometers per hour", "Meters per second", "Miles per hour"
                }
            },
            {
                SpecTypeId.Time, new List<string>
                {
                    "Hours", "Milliseconds", "Minutes", "Seconds"
                }
            },
            {
                SpecTypeId.Volume, new List<string>
                {
                    "Cubic centimeters",
                    "Cubic feet", 
                    "Cubic inches", 
                    "Cubic meters", 
                    "Cubic millimeters", 
                    "Cubic yards", 
                    "Liters", 
                    "US gallons"
                }
            }
        };

        // Mapping between unit names and ForgeTypeId
        public static readonly Dictionary<string, ForgeTypeId> UnitNameToSpec = new()
        {
            { "Angle", SpecTypeId.Angle },
            { "Area", SpecTypeId.Area },
            { "Cost per Area", SpecTypeId.CostPerArea },
            { "Length", SpecTypeId.Length },
            { "Distance", SpecTypeId.Distance },
            { "Mass Density", SpecTypeId.MassDensity },
            { "Rotation Angle", SpecTypeId.RotationAngle },
            { "Slope", SpecTypeId.Slope },
            { "Speed", SpecTypeId.Speed },
            { "Time", SpecTypeId.Time },
            { "Volume", SpecTypeId.Volume }
        };
    }
}