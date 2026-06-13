namespace UnitConversionApi.Api.Converters;

public class TemperatureConverter : IUnitConverter
{
    public string Category => "temperature";

    public double Convert(
        double value,
        string fromUnit,
        string toUnit)
    {
        fromUnit = fromUnit.ToLower();
        toUnit = toUnit.ToLower();

        double celsius = fromUnit switch
        {
            "celsius" => value,
            "fahrenheit" => (value - 32) * 5 / 9,
            "kelvin" => value - 273.15,
            _ => throw new ArgumentException("Invalid unit")
        };

        return toUnit switch
        {
            "celsius" => celsius,
            "fahrenheit" => celsius * 9 / 5 + 32,
            "kelvin" => celsius + 273.15,
            _ => throw new ArgumentException("Invalid unit")
        };
    }
}