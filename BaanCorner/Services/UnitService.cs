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
                "britishThermalUnitsPerHour" => "British thermal units per hour",
                "britishThermalUnitsPerSecond" => "British thermal units per second",
                "caloriesPerSecond" => "Calories per second",
                "horsepower" => "Horsepower",
                "kilocaloriesPerSecond" => "Kilocalories per second",
                "kilovoltAmperes" => "Kilovolt amperes",
                "kilowatts" => "Kilowatts",
                "voltAmperes" => "Volt amperes",
                "watts" => "Watts",
                "voltAmperesPerSquareFoot" => "Volt amperes per square foot",
                "voltAmperesPerSquareMeter" => "Volt amperes per square meter",
                "kelvin" => "Kelvin",
                "currencyPerBritishThermalUnit" => "Cost per British thermal unit",
                "currencyPerWattHour" => "Cost per watt hour",
                "currencyPerBritishThermalUnitPerHour" => "Cost per British thermal unit per hour",
                "currencyPerWatt" => "Cost per watt",
                "amperes" => "Amperes",
                "kiloamperes" => "Kiloamperes",
                "milliamperes" => "Milliamperes",
                "lux" => "Lumens per watt",
                "fixed" => "Fixed",
                "candelasPerSquareFoot" => "Candelas per square foot",
                "candelasPerSquareMeter" => "Candelas per square meter",
                "footlamberts" => "Footlamberts",
                "lumens" => "Lumens",
                "candelas" => "Candelas",
                "kilovolts" => "Kilovolts",
                "millivolts" => "Millivolts",
                "volts" => "Volts",
                "britishThermalUnitsPerHourSquareFoot" => "British thermal units per hour square foot",
                "wattsPerSquareFoot" => "Watts per square foot",
                "wattsPerSquareMeter" => "Watts per square meter",
                "wattsPerFoot" => "Watts per foot",
                "wattsPerMeter" => "Watts per meter",
                "ohmMeters" => "Ohm meters",
                "celsius" => "Celsius",
                "fahrenheit" => "Fahrenheit",
                "rankine" => "Rankine",
                "britishThermalUnits" => "British thermal units",
                "calories" => "Calories",
                "joules" => "Joules",
                "kilocalories" => "Kilocalories",
                "kilowattHours" => "Kilowatt hours",
                "therms" => "Therms",
                "poundForceFeet" => "Pound force feet",
                "britishThermalUnitsPerSquareFootDegreeFahrenheit" => "British thermal units per square foot degree Fahrenheit",
                "joulesPerSquareMeterKelvin" => "Joules per square meter Kelvin",
                "kilojoulesPerSquareMeterKelvin" => "Kilojoules per square meter Kelvin",
                "britishThermalUnitsPerHourSquareFootDegreeFahrenheit" => "British thermal units per hour square foot degree Fahrenheit",
                "wattsPerSquareMeterKelvin" => "Watts per square meter kelvin",
                "cubicFeetPerPoundMass" => "Cubic feet per pound mass",
                "cubicMetersPerKilogram" => "Cubic meters per kilogram",
                "grainsPerHourSquareFootInchMercury" => "Grains per hour square foot inch mercury",
                "nanogramsPerPascalSecondSquareMeter" => "Nanograms per pascal second square meter",
                "britishThermalUnitsPerPoundDegreeFahrenheit" => "British thermal units per pound degree Fahrenheit",
                "joulesPerGramDegreeCelsius" => "Joules per gram degree Celsius",
                "joulesPerKilogramDegreeCelsius" => "Joules per kilogram degree Celsius",
                "britishThermalUnitsPerPound" => "British thermal units per pound",
                "joulesPerGram" => "Joules per gram",
                "britishThermalUnitsPerHourFootDegreeFharenheit" => "British thermal units per hour foot degree Fahrenheit",
                "wattsPerMeterKelvin" => "Watts per meter kelvin",
                "kilogramsPerKilogramKelvin" => "Kilograms per kilogram kelvin",
                "poundsMassPerPoundDegreeFahrenheit" => "Kilograms per kilogram kelvin",
                "britishThermalUnitsPerDegreeFahrenheit" => "British thermal units per degree Fahrenheit",
                "joulesPerKelvin" => "Joules per Kelvin",
                "kilojoulesPerKelvin" => "Kilojoules per Kelvin",
                "hourSquareFootDegreesFahrenheitPerBritishThermalUnit" => "Hour square foot degrees Fahrenheit per British thermal unit",
                "squareMeterKelvinsPerWatt" => "Square meter kelvins per watt",
                _ => "Unknown"
            };
        }
    }
}