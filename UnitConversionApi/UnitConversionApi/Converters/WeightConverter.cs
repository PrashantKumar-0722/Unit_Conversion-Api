namespace UnitConversionApi.Api.Converters;

public class WeightConverter : IUnitConverter
{
    public string Category => "weight";

    private readonly Dictionary<string, double> _factors =
        new()
        {
            { "kilogram", 1 },
            { "gram", 0.001 },
            { "pound", 0.45359237 }
        };

    public double Convert(
        double value,
        string fromUnit,
        string toUnit)
    {
        var kilograms =
            value * _factors[fromUnit.ToLower()];

        return kilograms /
               _factors[toUnit.ToLower()];
    }
}