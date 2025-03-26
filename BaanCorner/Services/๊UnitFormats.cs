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
                    "Degrees", "Radians", "Gradians", "Degree minute second"
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
                    "Centimeter per minute", 
                    "Feet per minute", 
                    "Feet per second", 
                    "Kilometers per hour", 
                    "Meters per second", 
                    "Miles per hour"
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
            },
            {
                SpecTypeId.AirFlow, new List<string>
                {
                    "Cubic feet per hour",
                    "Cubic feet per minute",
                    "Cubic meters per hour",
                    "Cubic meters per second",
                    "Liters per hour",
                    "Liters per second",
                    "US gallons per hour",
                    "US gallons per minute"
                }
            },
            {
                SpecTypeId.AirFlowDensity, new List<string>
                {
                    "Cubic feet per minute square foot",
                    "Cubic meters per hour square meter",
                    "Liters per second square meter"
                }
            },
            {
                SpecTypeId.AirFlowDividedByCoolingLoad, new List<string>
                {
                    "Cubic feet per minute ton of refrigeration",
                    "Liters per second kilowatt"
                }
            },
            {
                SpecTypeId.AirFlowDividedByVolume, new List<string>
                {
                    "Cubic feet per minute cubic foot",
                    "Cubic meters per hour cubic meter",
                    "Liters per second cubic meter"
                }
            },
            {
                SpecTypeId.AngularSpeed, new List<string>
                {
                    "Revolutions per minute",
                    "Revolutions per second"
                }
            },
            {
                SpecTypeId.AreaDividedByCoolingLoad, new List<string>
                {
                    "Square feet per thousand British thermal units per hour",
                    "Square feet per ton of refrigeration",
                    "Square meters per kilowatt"
                }
            },
            {
                SpecTypeId.AreaDividedByHeatingLoad, new List<string>
                {
                    "Square feet per thousand British thermal units per hour",
                    "Square meters per kilowatt"
                }
            },
            {
                SpecTypeId.CoolingLoad, new List<string>
                {
                    "British thermal units per hour",
                    "British thermal units per second",
                    "Kilowatts",
                    "Tons of refrigeration",
                    "Watts"
                }
            },
            {
                SpecTypeId.CoolingLoadDividedByArea, new List<string>
                {
                    "British thermal units per hour square foot",
                    "Watts per square foot",
                    "Watts per square meter"
                }
            },
            {
                SpecTypeId.CoolingLoadDividedByVolume, new List<string>
                {
                    "British thermal units per hour cubic foot",
                    "Watts per cubic foot",
                    "Watts per cubic meter"
                }
            },
            {
                SpecTypeId.CrossSection, new List<string>
                {
                    "Acres",
                    "Hectares",
                    "Square centimeters",
                    "Square feet",
                    "Square inches",
                    "Square meters",
                    "Square millimeters"
                }
            },
            {
                SpecTypeId.HvacDensity, new List<string>
                {
                    "Kilograms per cubic meter",
                    "Pounds mass per cubic foot",
                    "Pounds mass per cubic inch"
                }
            },
            {
                SpecTypeId.Diffusivity, new List<string>
                {
                    "Square feet per second",
                    "Square meters per second"
                }
            },
            {
                SpecTypeId.DuctInsulationThickness, new List<string>
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
                SpecTypeId.DuctLiningThickness, new List<string>
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
                SpecTypeId.DuctSize, new List<string>
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
                SpecTypeId.Factor, new List<string>
                {
                    "Fixed",
                    "Percentage"
                }
            },
            {
                SpecTypeId.FlowPerPower, new List<string>
                {
                    "Cubic feet per minute per British thermal unit per hour",
                    "Cubic meters per watt second"
                }
            },
            {
                SpecTypeId.HvacFriction, new List<string>
                {
                    "Feet of water (39.2 \u00b0F) per 100 feet",
                    "Inches of water (60 \u00b0F) per 100 feet",
                    "Meters of water column per meter",
                    "Millimeters of water column per meter",
                    "Pascals per meter"
                    
                }
            },
            {
                 SpecTypeId.HeatGain, new   List<string>
                 {
                     "British thermal units per hour",
                     "British thermal units per second",
                     "Calories per second",
                     "Kilowatts",
                     "Watts"
                 }
            },
            {
                SpecTypeId.HeatingLoad, new List<string>
                {
                    "British thermal units per hour",
                    "British thermal units per second",
                    "Kilowatts",
                    "Watts"
                }
            },
            {
                SpecTypeId.HeatingLoadDividedByArea, new List<string>
                {
                    "British thermal units per hour square foot",
                    "Watts per square foot",
                    "Watts per square meter"
                }
            },
            {
                SpecTypeId.HeatingLoadDividedByVolume, new List<string>
                {
                    "British thermal units per hour square foot",
                    "Watts per square foot",
                    "Watts per square meter"
                }
            },
            {
                SpecTypeId.HvacMassPerTime, new List<string>
                {
                    "Kilograms per hour",
                    "Kilograms per minute",
                    "Kilograms per second",
                    "Pound per hour",
                    "Pound per minute",
                    "Pound per second"
                }
            },
            {
                SpecTypeId.HvacPower, new List<string>
                {
                    "British thermal units per hour",
                    "British thermal units per second",
                    "Calories per second",
                    "Kilocalories per second",
                    "Kilowatts",
                    "Watts"
                }
            },
            {
                SpecTypeId.HvacPowerDensity, new List<string>
                {
                    "British thermal units per hour square foot",
                    "Watts per square foot",
                    "Watts per square meter"
                }
            },
            {
                SpecTypeId.PowerPerFlow, new List<string>
                {
                    "Watts per cubic foot per minute",
                    "Watts per cubic meter per second"
                }
            },
            {
                SpecTypeId.HvacPressure, new List<string>
                {
                    "Atmospheres",
                    "Bars",
                    "Feet of water (39.2 \u00b0F)",
                    "Inches of mercury (32 \u00b0F)",
                    "Inches of water (60 \u00b0F)",
                    "Kilopascals",
                    "Megapascals",
                    "Meters of water column",
                    "Millimeters of mercury",
                    "Millimeters of water column",
                    "Pascals",
                    "Pounds force per square inch"
                }
            },
            {
                SpecTypeId.HvacRoughness, new List<string>
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
                SpecTypeId.HvacSlope, new List<string>
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
                SpecTypeId.HvacTemperature, new List<string>
                {
                    "Celsius",
                    "Fahrenheit",
                    "Kelvin",
                    "Rankine"
                }
            },
            {
                SpecTypeId.HvacVelocity, new List<string>
                {
                    "Centimeter per minute", 
                    "Feet per minute", 
                    "Feet per second", 
                    "Kilometers per hour", 
                    "Meters per second", 
                    "Miles per hour"
                }
            },
            {
              SpecTypeId.HvacViscosity, new List<string>
              {
                  "Centipoises",
                  "Kilograms per meter hour",
                  "Kilograms per meter second",
                  "Newton seconds per square meter",
                  "Pascal seconds",
                  "Pound force seconds per square foot",
                  "Pound mass per foot hour",
                  "Pounds mass per foot second"
              }  
            },
            {
                SpecTypeId.Stationing, new List<string>
                {
                    "Feet",
                    "Meters",
                    "US survey feet"
                }
            },
            {
                SpecTypeId.PipingDensity, new List<string>
                {
                    "Kilograms per cubic meter",
                    "Pounds mass per cubic foot",
                    "Pounds mass per cubic inch"
                }
            },
            {
                SpecTypeId.Flow, new List<string>
                {
                    "Cubic feet per hour",
                    "Cubic feet per minute",
                    "Cubic meters per hour",
                    "Cubic meters per minute",
                    "Liters per hour",
                    "Liters per minute",
                    "Liters per second",
                    "US gallons per hour",
                    "US gallons per minute"
                }
            },
            {
                SpecTypeId.PipingFriction, new List<string>
                {
                    "Feet of water (39.2 \u00b0F) per 100 feet",
                    "Inches of water (60 \u00b0F) per 100 feet",
                    "Meters of water column per meter",
                    "Millimeters of water column per meter",
                    "Pascals per meter"
                }
            },
            {
                SpecTypeId.PipingMassPerTime, new List<string>
                {
                    "Kilograms per hour",
                    "Kilograms per minute",
                    "Kilograms per second",
                    "Pounds mass per hour",
                    "Pounds mass per minute",
                    "Pounds mass per second"
                }
            },
            {
                SpecTypeId.PipeDimension, new List<string>
                {
                    "Centimeters",
                    "Inches",
                    "Millimeters",
                    "Fractional inches",
                }
            },
            {
                SpecTypeId.PipeInsulationThickness, new List<string>
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
                SpecTypeId.PipeMassPerUnitLength, new List<string>
                {
                    "Kilograms per meter",
                    "Pounds mass per foot"
                }
            },
            {
                SpecTypeId.PipeSize, new List<string>
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
                SpecTypeId.PipingPressure, new List<string>
                {
                    "Atmospheres",
                    "Bars",
                    "Feet of water (39.2 \u00b0F)",
                    "Inches of mercury (32 \u00b0F)",
                    "Inches of water (60 \u00b0F)",
                    "Kilopascals",
                    "Megapascals",
                    "Meters of water column",
                    "Millimeters of mercury",
                    "Millimeters of water column",
                    "Pascals",
                    "Pounds force per square inch"
                }
            },
            {
                SpecTypeId.PipingRoughness, new List<string>
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
                SpecTypeId.PipingSlope, new List<string>
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
                SpecTypeId.PipingTemperature, new List<string>
                {
                    "Celsius",
                    "Fahrenheit",
                    "Kelvin",
                    "Rankine"
                }
            },
            {
                SpecTypeId.PipingVelocity, new List<string>
                {
                    "Centimeter per minute", 
                    "Feet per minute", 
                    "Feet per second", 
                    "Kilometers per hour", 
                    "Meters per second", 
                    "Miles per hour"
                }
            },
            {
                SpecTypeId.PipingViscosity, new List<string>
                {
                    "Centipoises",
                    "Kilograms per meter hour",
                    "Kilograms per meter second",
                    "Newton seconds per square meter",
                    "Pascal seconds",
                    "Pound force seconds per square foot",
                    "Pound mass per foot hour",
                    "Pounds mass per foot second"
                }
            },
            {
                SpecTypeId.PipingVolume, new  List<string>
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

        static UnitFormats()
        {
            // Check for duplicates by grouping keys
            var duplicatedKeys = FormatMapping
                .GroupBy(pair => pair.Key)
                .Where(group => group.Count() > 1)
                .Select(group => group.Key)
                .ToList();

            if (duplicatedKeys.Count > 0)
            {
                throw new Exception($"Duplicate keys found: {string.Join(", ", duplicatedKeys)}");
            }

        }
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
            {"Thermal Resistance", SpecTypeId.ThermalResistance},
            {"Air Flow", SpecTypeId.AirFlow},
            {"Air Flow Density", SpecTypeId.AirFlowDensity},
            {"Air Flow divided by Cooling Load", SpecTypeId.AirFlowDividedByCoolingLoad},
            {"Air Flow divided by Volume", SpecTypeId.AirFlowDividedByVolume},
            {"Angular Speed", SpecTypeId.AngularSpeed},
            {"Area divided by Cooling Load", SpecTypeId.AreaDividedByCoolingLoad},
            {"Area divided by Heating Load", SpecTypeId.AreaDividedByHeatingLoad},
            {"Cooling Load", SpecTypeId.CoolingLoad},
            {"Cooling Load divided by Area", SpecTypeId.CoolingLoadDividedByArea},
            {"Cooling Load divided by Volume", SpecTypeId.CoolingLoadDividedByVolume},
            {"Cross Section", SpecTypeId.CrossSection},
            {"Density", SpecTypeId.HvacDensity},
            {"Diffusivity", SpecTypeId.Diffusivity},
            {"Duct Insulation Thickness", SpecTypeId.DuctInsulationThickness},
            {"Duct Lining Thickness", SpecTypeId.DuctLiningThickness},
            {"Duct Size", SpecTypeId.DuctSize},
            {"Factor", SpecTypeId.Factor},
            {"Flow per Power", SpecTypeId.FlowPerPower},
            {"Friction", SpecTypeId.HvacFriction},
            {"Heat Grain", SpecTypeId.HeatGain},
            {"Heating Load", SpecTypeId.HeatingLoad},
            {"Heating Load divided by Area", SpecTypeId.HeatingLoadDividedByArea},
            {"Heating Load divided by Volume", SpecTypeId.HeatingLoadDividedByVolume},
            {"Mass per Time", SpecTypeId.HvacMassPerTime},
            {"HVAC Power", SpecTypeId.HvacPower},
            {"HVAC Power Density", SpecTypeId.HvacPowerDensity},
            {"Power per Flow", SpecTypeId.PowerPerFlow},
            {"HVAC Pressure", SpecTypeId.HvacPressure},
            {"Roughness", SpecTypeId.HvacRoughness},
            {"HVAC Slope", SpecTypeId.HvacSlope},
            {"HVAC Temperature", SpecTypeId.HvacTemperature},
            {"HVAC Velocity", SpecTypeId.HvacVelocity},
            {"Dynamic Viscosity", SpecTypeId.HvacViscosity},
            {"Stationing", SpecTypeId.Stationing},
            {"Piping Density", SpecTypeId.PipingDensity},
            {"Flow", SpecTypeId.Flow},
            {"Piping Friction", SpecTypeId.PipingFriction},
            {"Piping Mass per Time", SpecTypeId.PipingMassPerTime},
            {"Pipe Dimension", SpecTypeId.PipeDimension},
            {"Pipe Insulation Thickness", SpecTypeId.PipeInsulationThickness},
            {"Pipe Mass per unit Lenght", SpecTypeId.PipeMassPerUnitLength},
            {"Pipe Size", SpecTypeId.PipeSize},
            {"Pipe Pressure", SpecTypeId.PipingPressure},
            {"Pipe Roughness", SpecTypeId.PipingRoughness},
            {"Pipe Slope", SpecTypeId.PipingSlope},
            {"Pipe Temperature", SpecTypeId.PipingTemperature},
            {"Pipe Velocity", SpecTypeId.PipingVelocity},
            {"Pipe Dynamic Viscosity", SpecTypeId.PipingViscosity},
            {"Pipe Volume", SpecTypeId.PipingVolume},
        };
    }
}