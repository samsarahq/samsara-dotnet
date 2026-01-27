using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<AttributeUnit>))]
[Serializable]
public readonly record struct AttributeUnit : IStringEnum
{
    public static readonly AttributeUnit NoUnit = new(Values.NoUnit);

    public static readonly AttributeUnit Meter = new(Values.Meter);

    public static readonly AttributeUnit Pound = new(Values.Pound);

    public static readonly AttributeUnit Ton = new(Values.Ton);

    public static readonly AttributeUnit Kilogram = new(Values.Kilogram);

    public static readonly AttributeUnit Inch = new(Values.Inch);

    public static readonly AttributeUnit Foot = new(Values.Foot);

    public static readonly AttributeUnit Gallon = new(Values.Gallon);

    public static readonly AttributeUnit Liter = new(Values.Liter);

    public static readonly AttributeUnit Barrel = new(Values.Barrel);

    public static readonly AttributeUnit PoundPerSquareInch = new(Values.PoundPerSquareInch);

    public static readonly AttributeUnit Bar = new(Values.Bar);

    public static readonly AttributeUnit Kilopascal = new(Values.Kilopascal);

    public static readonly AttributeUnit Fahrenheit = new(Values.Fahrenheit);

    public static readonly AttributeUnit Celsius = new(Values.Celsius);

    public static readonly AttributeUnit Usd = new(Values.Usd);

    public static readonly AttributeUnit Cad = new(Values.Cad);

    public static readonly AttributeUnit Eur = new(Values.Eur);

    public static readonly AttributeUnit Gbp = new(Values.Gbp);

    public static readonly AttributeUnit Mxn = new(Values.Mxn);

    public static readonly AttributeUnit Hour = new(Values.Hour);

    public static readonly AttributeUnit Minute = new(Values.Minute);

    public static readonly AttributeUnit Day = new(Values.Day);

    public static readonly AttributeUnit MilePerHour = new(Values.MilePerHour);

    public static readonly AttributeUnit KilometerPerHour = new(Values.KilometerPerHour);

    public static readonly AttributeUnit Horsepower = new(Values.Horsepower);

    public static readonly AttributeUnit Kilowatt = new(Values.Kilowatt);

    public static readonly AttributeUnit BtuPerHour = new(Values.BtuPerHour);

    public static readonly AttributeUnit KilowattHour = new(Values.KilowattHour);

    public static readonly AttributeUnit Btu = new(Values.Btu);

    public static readonly AttributeUnit Hertz = new(Values.Hertz);

    public static readonly AttributeUnit RevolutionPerMinute = new(Values.RevolutionPerMinute);

    public static readonly AttributeUnit Decibel = new(Values.Decibel);

    public AttributeUnit(string value)
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
    public static AttributeUnit FromCustom(string value)
    {
        return new AttributeUnit(value);
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

    public static bool operator ==(AttributeUnit value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AttributeUnit value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AttributeUnit value) => value.Value;

    public static explicit operator AttributeUnit(string value) => new(value);

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
