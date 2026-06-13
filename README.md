# Unit Conversion API

A RESTful API built using ASP.NET Core 8 that performs unit conversions across different categories including Length, Weight, and Temperature.

## Features

- Length Conversion
  - Meter ↔ Kilometer
  - Meter ↔ Centimeter
  - Kilometer ↔ Centimeter

- Weight Conversion
  - Kilogram ↔ Gram
  - Kilogram ↔ Pound
  - Gram ↔ Pound

- Temperature Conversion
  - Celsius ↔ Fahrenheit
  - Celsius ↔ Kelvin
  - Fahrenheit ↔ Kelvin

- Input Validation
- Error Handling
- Dependency Injection
- Swagger/OpenAPI Documentation
- Postman Tested

---

## Technologies Used

- ASP.NET Core 8
- C#
- Minimal API
- Dependency Injection
- Swagger / OpenAPI
- Postman
- Git
- GitHub

---

## Project Structure

```text
UnitConversionApi
│
├── Converters
│   ├── IUnitConverter.cs
│   ├── LengthConverter.cs
│   ├── WeightConverter.cs
│   └── TemperatureConverter.cs
│
├── Models
│   ├── ConversionRequest.cs
│   └── ConversionResponse.cs
│
├── Services
│   └── ConversionService.cs
│
├── Program.cs
├── appsettings.json
└── README.md
```

---

## API Endpoint

### Convert Units

**POST** `/convert`

---

## Request Body

```json
{
  "category": "length",
  "fromUnit": "meter",
  "toUnit": "kilometer",
  "value": 1000
}
```

---

## Successful Response

```json
{
  "originalValue": 1000,
  "fromUnit": "meter",
  "toUnit": "kilometer",
  "convertedValue": 1
}
```

---

## Example Requests

### Length Conversion

```json
{
  "category": "length",
  "fromUnit": "meter",
  "toUnit": "kilometer",
  "value": 1000
}
```

### Weight Conversion

```json
{
  "category": "weight",
  "fromUnit": "kilogram",
  "toUnit": "gram",
  "value": 5
}
```

### Temperature Conversion

```json
{
  "category": "temperature",
  "fromUnit": "celsius",
  "toUnit": "fahrenheit",
  "value": 100
}
```

---

## Error Response

When an invalid category or unit is provided:

```json
{
  "error": "Invalid unit"
}
```

**HTTP Status Code**

```text
400 Bad Request
```

---

## API Testing

The API was tested using:

- Swagger UI
- Postman

Test scenarios covered:

- Length conversions
- Weight conversions
- Temperature conversions
- Invalid unit validation
- Invalid category validation
- Error handling responses

---

## Running the Application

### Clone Repository

```bash
git clone https://github.com/PrashantKumar-0722/UnitConversion-Api.git
```

### Navigate to Project

```bash
cd UnitConversion-Api
```

### Restore Packages

```bash
dotnet restore
```

### Build Project

```bash
dotnet build
```

### Run Application

```bash
dotnet run
```

---

## Swagger Documentation

After running the application, open:

```text
https://localhost:<port>/swagger
```

Swagger UI provides interactive API documentation and allows testing endpoints directly from the browser.

---

## Design Highlights

- Strategy-based converter implementation using `IUnitConverter`
- Separation of concerns using Service Layer
- Dependency Injection for converter registration
- Clean and maintainable project structure
- Minimal API approach for lightweight REST endpoints

---

## Future Enhancements

- Add Volume Conversion
- Add Area Conversion
- Add Currency Conversion
- Add Unit Tests using xUnit
- Docker Support
- Logging and Monitoring

---

## Author

**Prashant Kumar**

GitHub: https://github.com/PrashantKumar-0722
