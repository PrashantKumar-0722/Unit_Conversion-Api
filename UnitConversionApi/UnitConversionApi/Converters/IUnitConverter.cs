namespace UnitConversionApi.Api.Converters;

public interface IUnitConverter
{
    string Category { get; }

    double Convert(
        double value,
        string fromUnit,
        string toUnit);
}