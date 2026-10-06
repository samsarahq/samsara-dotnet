using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<EntityCreatePartInventoryLocationTypeResponseBodyUnitOfMeasureType>)
)]
[Serializable]
public readonly record struct EntityCreatePartInventoryLocationTypeResponseBodyUnitOfMeasureType
    : IStringEnum
{
    public static readonly EntityCreatePartInventoryLocationTypeResponseBodyUnitOfMeasureType Unknown =
        new(Values.Unknown);

    public static readonly EntityCreatePartInventoryLocationTypeResponseBodyUnitOfMeasureType Each =
        new(Values.Each);

    public static readonly EntityCreatePartInventoryLocationTypeResponseBodyUnitOfMeasureType Set =
        new(Values.Set);

    public static readonly EntityCreatePartInventoryLocationTypeResponseBodyUnitOfMeasureType Pack =
        new(Values.Pack);

    public static readonly EntityCreatePartInventoryLocationTypeResponseBodyUnitOfMeasureType Box =
        new(Values.Box);

    public static readonly EntityCreatePartInventoryLocationTypeResponseBodyUnitOfMeasureType Pound =
        new(Values.Pound);

    public static readonly EntityCreatePartInventoryLocationTypeResponseBodyUnitOfMeasureType Kilogram =
        new(Values.Kilogram);

    public static readonly EntityCreatePartInventoryLocationTypeResponseBodyUnitOfMeasureType Ounce =
        new(Values.Ounce);

    public static readonly EntityCreatePartInventoryLocationTypeResponseBodyUnitOfMeasureType Liter =
        new(Values.Liter);

    public static readonly EntityCreatePartInventoryLocationTypeResponseBodyUnitOfMeasureType Milliliter =
        new(Values.Milliliter);

    public static readonly EntityCreatePartInventoryLocationTypeResponseBodyUnitOfMeasureType Gallon =
        new(Values.Gallon);

    public static readonly EntityCreatePartInventoryLocationTypeResponseBodyUnitOfMeasureType Quart =
        new(Values.Quart);

    public static readonly EntityCreatePartInventoryLocationTypeResponseBodyUnitOfMeasureType FluidOunce =
        new(Values.FluidOunce);

    public static readonly EntityCreatePartInventoryLocationTypeResponseBodyUnitOfMeasureType Inch =
        new(Values.Inch);

    public static readonly EntityCreatePartInventoryLocationTypeResponseBodyUnitOfMeasureType Foot =
        new(Values.Foot);

    public static readonly EntityCreatePartInventoryLocationTypeResponseBodyUnitOfMeasureType Meter =
        new(Values.Meter);

    public static readonly EntityCreatePartInventoryLocationTypeResponseBodyUnitOfMeasureType Yard =
        new(Values.Yard);

    public static readonly EntityCreatePartInventoryLocationTypeResponseBodyUnitOfMeasureType SquareFoot =
        new(Values.SquareFoot);

    public static readonly EntityCreatePartInventoryLocationTypeResponseBodyUnitOfMeasureType SquareMeter =
        new(Values.SquareMeter);

    public static readonly EntityCreatePartInventoryLocationTypeResponseBodyUnitOfMeasureType Pint =
        new(Values.Pint);

    public static readonly EntityCreatePartInventoryLocationTypeResponseBodyUnitOfMeasureType Hundred =
        new(Values.Hundred);

    public static readonly EntityCreatePartInventoryLocationTypeResponseBodyUnitOfMeasureType Roll =
        new(Values.Roll);

    public EntityCreatePartInventoryLocationTypeResponseBodyUnitOfMeasureType(string value)
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
    public static EntityCreatePartInventoryLocationTypeResponseBodyUnitOfMeasureType FromCustom(
        string value
    )
    {
        return new EntityCreatePartInventoryLocationTypeResponseBodyUnitOfMeasureType(value);
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
        EntityCreatePartInventoryLocationTypeResponseBodyUnitOfMeasureType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        EntityCreatePartInventoryLocationTypeResponseBodyUnitOfMeasureType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        EntityCreatePartInventoryLocationTypeResponseBodyUnitOfMeasureType value
    ) => value.Value;

    public static explicit operator EntityCreatePartInventoryLocationTypeResponseBodyUnitOfMeasureType(
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
