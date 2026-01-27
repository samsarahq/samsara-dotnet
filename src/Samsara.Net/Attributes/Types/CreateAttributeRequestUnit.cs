using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Attributes;

[JsonConverter(typeof(StringEnumSerializer<CreateAttributeRequestUnit>))]
[Serializable]
public readonly record struct CreateAttributeRequestUnit : IStringEnum
{
    public static readonly CreateAttributeRequestUnit NoUnit = new(Values.NoUnit);

    public static readonly CreateAttributeRequestUnit Meter = new(Values.Meter);

    public static readonly CreateAttributeRequestUnit Pound = new(Values.Pound);

    public static readonly CreateAttributeRequestUnit Ton = new(Values.Ton);

    public static readonly CreateAttributeRequestUnit Kilogram = new(Values.Kilogram);

    public static readonly CreateAttributeRequestUnit Inch = new(Values.Inch);

    public static readonly CreateAttributeRequestUnit Foot = new(Values.Foot);

    public static readonly CreateAttributeRequestUnit Gallon = new(Values.Gallon);

    public static readonly CreateAttributeRequestUnit Liter = new(Values.Liter);

    public static readonly CreateAttributeRequestUnit Barrel = new(Values.Barrel);

    public static readonly CreateAttributeRequestUnit PoundPerSquareInch = new(
        Values.PoundPerSquareInch
    );

    public static readonly CreateAttributeRequestUnit Bar = new(Values.Bar);

    public static readonly CreateAttributeRequestUnit Kilopascal = new(Values.Kilopascal);

    public static readonly CreateAttributeRequestUnit Fahrenheit = new(Values.Fahrenheit);

    public static readonly CreateAttributeRequestUnit Celsius = new(Values.Celsius);

    public static readonly CreateAttributeRequestUnit Usd = new(Values.Usd);

    public static readonly CreateAttributeRequestUnit Cad = new(Values.Cad);

    public static readonly CreateAttributeRequestUnit Eur = new(Values.Eur);

    public static readonly CreateAttributeRequestUnit Gbp = new(Values.Gbp);

    public static readonly CreateAttributeRequestUnit Mxn = new(Values.Mxn);

    public static readonly CreateAttributeRequestUnit Hour = new(Values.Hour);

    public static readonly CreateAttributeRequestUnit Minute = new(Values.Minute);

    public static readonly CreateAttributeRequestUnit Day = new(Values.Day);

    public static readonly CreateAttributeRequestUnit MilePerHour = new(Values.MilePerHour);

    public static readonly CreateAttributeRequestUnit KilometerPerHour = new(
        Values.KilometerPerHour
    );

    public static readonly CreateAttributeRequestUnit Horsepower = new(Values.Horsepower);

    public static readonly CreateAttributeRequestUnit Kilowatt = new(Values.Kilowatt);

    public static readonly CreateAttributeRequestUnit BtuPerHour = new(Values.BtuPerHour);

    public static readonly CreateAttributeRequestUnit KilowattHour = new(Values.KilowattHour);

    public static readonly CreateAttributeRequestUnit Btu = new(Values.Btu);

    public static readonly CreateAttributeRequestUnit Hertz = new(Values.Hertz);

    public static readonly CreateAttributeRequestUnit RevolutionPerMinute = new(
        Values.RevolutionPerMinute
    );

    public static readonly CreateAttributeRequestUnit Decibel = new(Values.Decibel);

    public CreateAttributeRequestUnit(string value)
    {
        Value = value;
    }

    /// <summary>
    /// The string value of the enum.
    /// </summary>
    public string Value { get; }

    /// <summary>
    /// Create a string enum with the given value.
    /// </summary>
    public static CreateAttributeRequestUnit FromCustom(string value)
    {
        return new CreateAttributeRequestUnit(value);
    }

    public bool Equals(string? other)
    {
        return Value.Equals(other);
    }

    /// <summary>
    /// Returns the string value of the enum.
    /// </summary>
    public override string ToString()
    {
        return Value;
    }

    public static bool operator ==(CreateAttributeRequestUnit value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(CreateAttributeRequestUnit value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(CreateAttributeRequestUnit value) => value.Value;

    public static explicit operator CreateAttributeRequestUnit(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string NoUnit = "NO_UNIT";

        public const string Meter = "METER";

        public const string Pound = "POUND";

        public const string Ton = "TON";

        public const string Kilogram = "KILOGRAM";

        public const string Inch = "INCH";

        public const string Foot = "FOOT";

        public const string Gallon = "GALLON";

        public const string Liter = "LITER";

        public const string Barrel = "BARREL";

        public const string PoundPerSquareInch = "POUND_PER_SQUARE_INCH";

        public const string Bar = "BAR";

        public const string Kilopascal = "KILOPASCAL";

        public const string Fahrenheit = "FAHRENHEIT";

        public const string Celsius = "CELSIUS";

        public const string Usd = "USD";

        public const string Cad = "CAD";

        public const string Eur = "EUR";

        public const string Gbp = "GBP";

        public const string Mxn = "MXN";

        public const string Hour = "HOUR";

        public const string Minute = "MINUTE";

        public const string Day = "DAY";

        public const string MilePerHour = "MILE_PER_HOUR";

        public const string KilometerPerHour = "KILOMETER_PER_HOUR";

        public const string Horsepower = "HORSEPOWER";

        public const string Kilowatt = "KILOWATT";

        public const string BtuPerHour = "BTU_PER_HOUR";

        public const string KilowattHour = "KILOWATT_HOUR";

        public const string Btu = "BTU";

        public const string Hertz = "HERTZ";

        public const string RevolutionPerMinute = "REVOLUTION_PER_MINUTE";

        public const string Decibel = "DECIBEL";
    }
}
