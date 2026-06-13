using UnitConversionApi.Api.Converters;

namespace UnitConversionApi.Api.Services;

public class ConversionService
{
    private readonly Dictionary<string, IUnitConverter> _converters;

    public ConversionService(IEnumerable<IUnitConverter> converters)
    {
        _converters = converters.ToDictionary(
            c => c.Category.ToLower());
    }

    public double Convert(
        string category,
        double value,
        string fromUnit,
        string toUnit)
    {
        if (!_converters.ContainsKey(category.ToLower()))
        {
            throw new ArgumentException(
                $"Category '{category}' is not supported.");
        }

        return _converters[category.ToLower()]
            .Convert(value, fromUnit, toUnit);
    }
}