using UnitConversionApi.Api.Converters;
using UnitConversionApi.Api.Services;
using UnitConversionApi.Api.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<IUnitConverter, LengthConverter>();
builder.Services.AddSingleton<IUnitConverter, WeightConverter>();
builder.Services.AddSingleton<IUnitConverter, TemperatureConverter>();

builder.Services.AddSingleton<ConversionService>();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapPost("/convert",
    (
        ConversionRequest request,
        ConversionService service
    ) =>
    {
        try
        {
            var result = service.Convert(
                request.Category,
                request.Value,
                request.FromUnit,
                request.ToUnit);

            return Results.Ok(
                new ConversionResponse
                {
                    OriginalValue = request.Value,
                    FromUnit = request.FromUnit,
                    ToUnit = request.ToUnit,
                    ConvertedValue = Math.Round(result, 4)
                });
        }
        catch (ArgumentException ex)
        {
            return Results.BadRequest(
                new
                {
                    Error = ex.Message
                });
        }
    });

app.Run();