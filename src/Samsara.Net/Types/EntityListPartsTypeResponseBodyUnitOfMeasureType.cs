using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<EntityListPartsTypeResponseBodyUnitOfMeasureType>))]
[Serializable]
public readonly record struct EntityListPartsTypeResponseBodyUnitOfMeasureType : IStringEnum
{
    public static readonly EntityListPartsTypeResponseBodyUnitOfMeasureType Unknown = new(
        Values.Unknown
    );

    public static readonly EntityListPartsTypeResponseBodyUnitOfMeasureType Each = new(Values.Each);

    public static readonly EntityListPartsTypeResponseBodyUnitOfMeasureType Set = new(Values.Set);

    public static readonly EntityListPartsTypeResponseBodyUnitOfMeasureType Pack = new(Values.Pack);

    public static readonly EntityListPartsTypeResponseBodyUnitOfMeasureType Box = new(Values.Box);

    public static readonly EntityListPartsTypeResponseBodyUnitOfMeasureType Pound = new(
        Values.Pound
    );

    public static readonly EntityListPartsTypeResponseBodyUnitOfMeasureType Kilogram = new(
        Values.Kilogram
    );

    public static readonly EntityListPartsTypeResponseBodyUnitOfMeasureType Ounce = new(
        Values.Ounce
    );

    public static readonly EntityListPartsTypeResponseBodyUnitOfMeasureType Liter = new(
        Values.Liter
    );

    public static readonly EntityListPartsTypeResponseBodyUnitOfMeasureType Milliliter = new(
        Values.Milliliter
    );

    public static readonly EntityListPartsTypeResponseBodyUnitOfMeasureType Gallon = new(
        Values.Gallon
    );

    public static readonly EntityListPartsTypeResponseBodyUnitOfMeasureType Quart = new(
        Values.Quart
    );

    public static readonly EntityListPartsTypeResponseBodyUnitOfMeasureType FluidOunce = new(
        Values.FluidOunce
    );

    public static readonly EntityListPartsTypeResponseBodyUnitOfMeasureType Inch = new(Values.Inch);

    public static readonly EntityListPartsTypeResponseBodyUnitOfMeasureType Foot = new(Values.Foot);

    public static readonly EntityListPartsTypeResponseBodyUnitOfMeasureType Meter = new(
        Values.Meter
    );

    public static readonly EntityListPartsTypeResponseBodyUnitOfMeasureType Yard = new(Values.Yard);

    public static readonly EntityListPartsTypeResponseBodyUnitOfMeasureType SquareFoot = new(
        Values.SquareFoot
    );

    public static readonly EntityListPartsTypeResponseBodyUnitOfMeasureType SquareMeter = new(
        Values.SquareMeter
    );

    public static readonly EntityListPartsTypeResponseBodyUnitOfMeasureType Pint = new(Values.Pint);

    public static readonly EntityListPartsTypeResponseBodyUnitOfMeasureType Hundred = new(
        Values.Hundred
    );

    public static readonly EntityListPartsTypeResponseBodyUnitOfMeasureType Roll = new(Values.Roll);

    public EntityListPartsTypeResponseBodyUnitOfMeasureType(string value)
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
    public static EntityListPartsTypeResponseBodyUnitOfMeasureType FromCustom(string value)
    {
        return new EntityListPartsTypeResponseBodyUnitOfMeasureType(value);
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
        EntityListPartsTypeResponseBodyUnitOfMeasureType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        EntityListPartsTypeResponseBodyUnitOfMeasureType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        EntityListPartsTypeResponseBodyUnitOfMeasureType value
    ) => value.Value;

    public static explicit operator EntityListPartsTypeResponseBodyUnitOfMeasureType(
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
