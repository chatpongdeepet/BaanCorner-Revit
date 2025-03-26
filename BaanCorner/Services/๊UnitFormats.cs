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
            },
            {
                SpecTypeId.ApparentPower, new List<string>
                {
                    "British thermal units per hour",
                    "British thermal units per second",
                    "Calories per second",
                    "Horsepower",
                    "Kilocalories per second",
                    "Kilovolt amperes",
                    "Kilowatts",
                    "Volt amperes",
                    "Watts"
                }
                
            },
            {
                SpecTypeId.ApparentPowerDensity, new List<string>
                {
                    "Volt amperes per square foot",
                    "Volt amperes per square meter"
                }
            },
            {
                SpecTypeId.CableTraySize, new List<string>
                {
                    "Centimeters",
                    "Decimeters",
                    "Feet",
                    "Inches",
                    "Meters",
                    "Millimeters",
                    "Feet and fractional inches",
                    "Fractional inches",
                    "Meters and centimeters"
                }
            },
            {
                SpecTypeId.ColorTemperature, new List<string>
                {
                    "Kelvin"
                }
            },
            {
                SpecTypeId.ConduitSize, new List<string>
                {
                    "Centimeters",
                    "Decimeters",
                    "Feet",
                    "Inches",
                    "Meters",
                    "Millimeters",
                    "Feet and fractional inches",
                    "Fractional inches",
                    "Meters and centimeters"
                }
            },
            {
                SpecTypeId.CostRateEnergy, new List<string>
                {
                    "Cost per British thermal unit",
                    "Cost per watt hour"
                }
            },
            {
                SpecTypeId.CostRatePower, new List<string>
                {
                    "Cost per British thermal unit per hour",
                    "Cost per watt"
                }
            },
            { 
                SpecTypeId.Current, new List<string>
                {
                    "Amperes",
                    "Kiloamperes",
                    "Milliamperes"
                }
                
            },
            {
                SpecTypeId.DemandFactor, new List<string>
                {
                    "Fixed", 
                    "Percentage"
                }
            },
            {
                SpecTypeId.Illuminance, new List<string>
                {
                    "Lumens per watt"
                }
            },
            {
                SpecTypeId.Luminance, new List<string>
                {
                    "Candelas per square foot",
                    "Candelas per square meter",
                    "Footlamberts"
                }
            },
            {
                SpecTypeId.LuminousFlux, new List<string>
                {
                    "Lumens"
                }
            },
            {
                SpecTypeId.LuminousIntensity, new List<string>
                {
                    "Candelas"
                }
            },
            {
              SpecTypeId.ElectricalPotential, new  List<string>
              {
                  "Kilovolts",
                  "Millivolts",
                  "Volts"
              }
            },
            {
                SpecTypeId.ElectricalPower, new List<string>
                {
                    "British thermal units per hour",
                    "British thermal units per second",
                    "Calories per second",
                    "Horsepower",
                    "Kilocalories per second",
                    "Kilovolt amperes",
                    "Kilowatts",
                    "Volt amperes",
                    "Watts"
                }
            },
            {
                SpecTypeId.ElectricalPowerDensity, new List<string>
                {
                    "British thermal units per hour square foot",
                    "Watts per square foot",
                    "Watt per square meter"
                }
            },
            {
                SpecTypeId.PowerPerLength, new List<string>
                {
                    "Watts per foot",
                    "Watts per meter"
                }
            },
            {
                SpecTypeId.ElectricalResistivity, new List<string>
                {
                    "Ohm meters"
                }
            },
            {
                SpecTypeId.ElectricalTemperature, new List<string>
                {
                    "Celsius",
                    "Fahrenheit",
                    "Kelvin",
                    "Rankine"
                }
            },
            {
                SpecTypeId.Wattage, new List<string>
                {
                    "Watts"
                }
            },
            {
                SpecTypeId.WireDiameter, new List<string>
                {
                    "Centimeters",
                    "Decimeters",
                    "Feet",
                    "Meters",
                    "Inches",
                    "Millimeters",
                    "Feet and fractional inches",
                    "Fractional inches",
                    "Meters and centimeters"
                }
            },
            {
                SpecTypeId.Energy, new List<string>
                {
                    "British thermal unit",
                    "Calories",
                    "Joules",
                    "Kilocalories",
                    "Kilowatt hours",
                    "Therms",
                    "Pound force feet"
                }
            },
            {
                SpecTypeId.HeatCapacityPerArea, new List<string>
                {
                    "British thermal units per square foot degree Fahrenheit",
                    "Joules per square meter Kelvin",
                    "Kilojoules per square meter Kelvin"
                }
            },
            {
                SpecTypeId.HeatTransferCoefficient, new List<string>
                {
                    "British thermal units per hour square foot degree Fahrenheit",
                    "Watts per square meter kelvin"
                }
            },
            {
                SpecTypeId.IsothermalMoistureCapacity, new List<string>
                {
                    "Cubic feet per pound mass",
                    "Cubic meters per kilogram"
                }
            },
            {
                SpecTypeId.Permeability, new List<string>
                {
                    "Grains per hour square foot inch mercury",
                    "Nanograms per pascal second square meter"
                }
            },
            {
                SpecTypeId.SpecificHeat, new List<string>
                {
                    "British thermal units per pound degree Fahrenheit",
                    "Joules per gram degree Celsius",
                    "Joules per kilogram degree Celsius"
                }
            },
            {
                SpecTypeId.SpecificHeatOfVaporization, new List<string>
                {
                    "British thermal units per pound",
                    "Joules per gram"
                }
            },
            {
                SpecTypeId.ThermalConductivity, new List<string>
                {
                    "British thermal units per hour foot degree Fahrenheit",
                    "Watts per meter kelvin"
                }
            },
            {
                SpecTypeId.ThermalGradientCoefficientForMoistureCapacity, new List<string>
                {
                    "Kilograms per kilogram kelvin",
                    "Pounds mass per pound degree Fahrenheit"
                }
            },
            {
                SpecTypeId.ThermalMass, new List<string>
                {
                    "British thermal units per degree Fahrenheit",
                    "Joules per Kelvin",
                    "Kilojoules per Kelvin"
                }
            },
            {
                SpecTypeId.ThermalResistance, new List<string>
                {
                    "Hour square foot degrees Fahrenheit per British thermal unit",
                    "Square meter kelvins per watt"
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
            { "Volume", SpecTypeId.Volume },
            {"Apparent Power", SpecTypeId.ApparentPower},
            {"Apparent Power Density", SpecTypeId.ApparentPowerDensity},
            {"Cable Tray Size", SpecTypeId.CableTraySize},
            {"Color Temperature", SpecTypeId.ColorTemperature}, 
            {"Conduit Size", SpecTypeId.ConduitSize},
            {"Cost Rate Energy", SpecTypeId.CostRateEnergy},
            {"Cost Rate Power", SpecTypeId.CostRatePower},
            {"Current", SpecTypeId.Current},
            {"Demand Factor", SpecTypeId.DemandFactor},
            {"Illuminance", SpecTypeId.Illuminance},
            {"Luminance", SpecTypeId.Luminance},
            {"Luminous Flux", SpecTypeId.LuminousFlux},
            {"Luminous Intensity", SpecTypeId.LuminousIntensity},
            {"Electrical Potential", SpecTypeId.ElectricalPotential},
            {"Power", SpecTypeId.ElectricalPower},
            {"Power Density", SpecTypeId.ElectricalPowerDensity},
            {"Power per Length", SpecTypeId.PowerPerLength},
            {"Electrical Resistivity", SpecTypeId.ElectricalResistivity},
            {"Temperature", SpecTypeId.ElectricalTemperature},
            {"Wattage", SpecTypeId.Wattage},
            {"Wire Diameter", SpecTypeId.WireDiameter},
            {"Energy", SpecTypeId.Energy},
            {"Heat Capacity per Area", SpecTypeId.HeatCapacityPerArea},
            {"Coefficient of Heat Transfer", SpecTypeId.HeatTransferCoefficient},
            {"Isothermal Moisture Capacity", SpecTypeId.IsothermalMoistureCapacity},
            {"Permeability", SpecTypeId.Permeability},
            {"Specific Heat", SpecTypeId.SpecificHeat},
            {"Specific Heat of Vaporization", SpecTypeId.SpecificHeatOfVaporization},
            {"Thermal Conductivity", SpecTypeId.ThermalConductivity},
            {"Thermal Gradient Coefficient", SpecTypeId.ThermalGradientCoefficientForMoistureCapacity},
            {"Thermal Mass", SpecTypeId.ThermalMass},
            {"Thermal Resistance", SpecTypeId.ThermalResistance}
        };
    }
}