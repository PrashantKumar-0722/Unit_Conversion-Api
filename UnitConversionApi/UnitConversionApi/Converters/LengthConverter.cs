namespace UnitConversionApi.Api.Converters;

public class LengthConverter : IUnitConverter
{
    public string Category => "length";

    private readonly Dictionary<string, double> _factors =
        new()
        {
            { "meter", 1 },
            { "kilometer", 1000 },
            { "foot", 0.3048 },
            { "inch", 0.0254 }
        };

    public double Convert(
    double value,
    string fromUnit,
    string toUnit)
    {
        fromUnit = fromUnit.ToLower();
        toUnit = toUnit.ToLower();

        if (!_factors.ContainsKey(fromUnit))
        {
            throw new ArgumentException(
                $"Unit '{fromUnit}' is not supported.");
        }

        if (!_factors.ContainsKey(toUnit))
        {
            throw new ArgumentException(
                $"Unit '{toUnit}' is not supported.");
        }

        var meters = value * _factors[fromUnit];

        return meters / _factors[toUnit];
    }
}