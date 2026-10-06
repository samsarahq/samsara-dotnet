using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<EntityUpdatePartTypeResponseBodyUnitOfMeasureType>))]
[Serializable]
public readonly record struct EntityUpdatePartTypeResponseBodyUnitOfMeasureType : IStringEnum
{
    public static readonly EntityUpdatePartTypeResponseBodyUnitOfMeasureType Unknown = new(
        Values.Unknown
    );

    public static readonly EntityUpdatePartTypeResponseBodyUnitOfMeasureType Each = new(
        Values.Each
    );

    public static readonly EntityUpdatePartTypeResponseBodyUnitOfMeasureType Set = new(Values.Set);

    public static readonly EntityUpdatePartTypeResponseBodyUnitOfMeasureType Pack = new(
        Values.Pack
    );

    public static readonly EntityUpdatePartTypeResponseBodyUnitOfMeasureType Box = new(Values.Box);

    public static readonly EntityUpdatePartTypeResponseBodyUnitOfMeasureType Pound = new(
        Values.Pound
    );

    public static readonly EntityUpdatePartTypeResponseBodyUnitOfMeasureType Kilogram = new(
        Values.Kilogram
    );

    public static readonly EntityUpdatePartTypeResponseBodyUnitOfMeasureType Ounce = new(
        Values.Ounce
    );

    public static readonly EntityUpdatePartTypeResponseBodyUnitOfMeasureType Liter = new(
        Values.Liter
    );

    public static readonly EntityUpdatePartTypeResponseBodyUnitOfMeasureType Milliliter = new(
        Values.Milliliter
    );

    public static readonly EntityUpdatePartTypeResponseBodyUnitOfMeasureType Gallon = new(
        Values.Gallon
    );

    public static readonly EntityUpdatePartTypeResponseBodyUnitOfMeasureType Quart = new(
        Values.Quart
    );

    public static readonly EntityUpdatePartTypeResponseBodyUnitOfMeasureType FluidOunce = new(
        Values.FluidOunce
    );

    public static readonly EntityUpdatePartTypeResponseBodyUnitOfMeasureType Inch = new(
        Values.Inch
    );

    public static readonly EntityUpdatePartTypeResponseBodyUnitOfMeasureType Foot = new(
        Values.Foot
    );

    public static readonly EntityUpdatePartTypeResponseBodyUnitOfMeasureType Meter = new(
        Values.Meter
    );

    public static readonly EntityUpdatePartTypeResponseBodyUnitOfMeasureType Yard = new(
        Values.Yard
    );

    public static readonly EntityUpdatePartTypeResponseBodyUnitOfMeasureType SquareFoot = new(
        Values.SquareFoot
    );

    public static readonly EntityUpdatePartTypeResponseBodyUnitOfMeasureType SquareMeter = new(
        Values.SquareMeter
    );

    public static readonly EntityUpdatePartTypeResponseBodyUnitOfMeasureType Pint = new(
        Values.Pint
    );

    public static readonly EntityUpdatePartTypeResponseBodyUnitOfMeasureType Hundred = new(
        Values.Hundred
    );

    public static readonly EntityUpdatePartTypeResponseBodyUnitOfMeasureType Roll = new(
        Values.Roll
    );

    public EntityUpdatePartTypeResponseBodyUnitOfMeasureType(string value)
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
    public static EntityUpdatePartTypeResponseBodyUnitOfMeasureType FromCustom(string value)
    {
        return new EntityUpdatePartTypeResponseBodyUnitOfMeasureType(value);
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
        EntityUpdatePartTypeResponseBodyUnitOfMeasureType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        EntityUpdatePartTypeResponseBodyUnitOfMeasureType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        EntityUpdatePartTypeResponseBodyUnitOfMeasureType value
    ) => value.Value;

    public static explicit operator EntityUpdatePartTypeResponseBodyUnitOfMeasureType(
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
