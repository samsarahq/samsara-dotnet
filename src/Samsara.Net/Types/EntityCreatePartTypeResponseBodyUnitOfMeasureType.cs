using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<EntityCreatePartTypeResponseBodyUnitOfMeasureType>))]
[Serializable]
public readonly record struct EntityCreatePartTypeResponseBodyUnitOfMeasureType : IStringEnum
{
    public static readonly EntityCreatePartTypeResponseBodyUnitOfMeasureType Unknown = new(
        Values.Unknown
    );

    public static readonly EntityCreatePartTypeResponseBodyUnitOfMeasureType Each = new(
        Values.Each
    );

    public static readonly EntityCreatePartTypeResponseBodyUnitOfMeasureType Set = new(Values.Set);

    public static readonly EntityCreatePartTypeResponseBodyUnitOfMeasureType Pack = new(
        Values.Pack
    );

    public static readonly EntityCreatePartTypeResponseBodyUnitOfMeasureType Box = new(Values.Box);

    public static readonly EntityCreatePartTypeResponseBodyUnitOfMeasureType Pound = new(
        Values.Pound
    );

    public static readonly EntityCreatePartTypeResponseBodyUnitOfMeasureType Kilogram = new(
        Values.Kilogram
    );

    public static readonly EntityCreatePartTypeResponseBodyUnitOfMeasureType Ounce = new(
        Values.Ounce
    );

    public static readonly EntityCreatePartTypeResponseBodyUnitOfMeasureType Liter = new(
        Values.Liter
    );

    public static readonly EntityCreatePartTypeResponseBodyUnitOfMeasureType Milliliter = new(
        Values.Milliliter
    );

    public static readonly EntityCreatePartTypeResponseBodyUnitOfMeasureType Gallon = new(
        Values.Gallon
    );

    public static readonly EntityCreatePartTypeResponseBodyUnitOfMeasureType Quart = new(
        Values.Quart
    );

    public static readonly EntityCreatePartTypeResponseBodyUnitOfMeasureType FluidOunce = new(
        Values.FluidOunce
    );

    public static readonly EntityCreatePartTypeResponseBodyUnitOfMeasureType Inch = new(
        Values.Inch
    );

    public static readonly EntityCreatePartTypeResponseBodyUnitOfMeasureType Foot = new(
        Values.Foot
    );

    public static readonly EntityCreatePartTypeResponseBodyUnitOfMeasureType Meter = new(
        Values.Meter
    );

    public static readonly EntityCreatePartTypeResponseBodyUnitOfMeasureType Yard = new(
        Values.Yard
    );

    public static readonly EntityCreatePartTypeResponseBodyUnitOfMeasureType SquareFoot = new(
        Values.SquareFoot
    );

    public static readonly EntityCreatePartTypeResponseBodyUnitOfMeasureType SquareMeter = new(
        Values.SquareMeter
    );

    public static readonly EntityCreatePartTypeResponseBodyUnitOfMeasureType Pint = new(
        Values.Pint
    );

    public static readonly EntityCreatePartTypeResponseBodyUnitOfMeasureType Hundred = new(
        Values.Hundred
    );

    public static readonly EntityCreatePartTypeResponseBodyUnitOfMeasureType Roll = new(
        Values.Roll
    );

    public EntityCreatePartTypeResponseBodyUnitOfMeasureType(string value)
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
    public static EntityCreatePartTypeResponseBodyUnitOfMeasureType FromCustom(string value)
    {
        return new EntityCreatePartTypeResponseBodyUnitOfMeasureType(value);
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

    public static bool operator ==(
        EntityCreatePartTypeResponseBodyUnitOfMeasureType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        EntityCreatePartTypeResponseBodyUnitOfMeasureType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        EntityCreatePartTypeResponseBodyUnitOfMeasureType value
    ) => value.Value;

    public static explicit operator EntityCreatePartTypeResponseBodyUnitOfMeasureType(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Unknown = "Unknown";

        public const string Each = "Each";

        public const string Set = "Set";

        public const string Pack = "Pack";

        public const string Box = "Box";

        public const string Pound = "Pound";

        public const string Kilogram = "Kilogram";

        public const string Ounce = "Ounce";

        public const string Liter = "Liter";

        public const string Milliliter = "Milliliter";

        public const string Gallon = "Gallon";

        public const string Quart = "Quart";

        public const string FluidOunce = "FluidOunce";

        public const string Inch = "Inch";

        public const string Foot = "Foot";

        public const string Meter = "Meter";

        public const string Yard = "Yard";

        public const string SquareFoot = "SquareFoot";

        public const string SquareMeter = "SquareMeter";

        public const string Pint = "Pint";

        public const string Hundred = "Hundred";

        public const string Roll = "Roll";
    }
}
