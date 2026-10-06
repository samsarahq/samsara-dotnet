using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<EntityUpdatePartInventoryLocationTypeResponseBodyUnitOfMeasureType>)
)]
[Serializable]
public readonly record struct EntityUpdatePartInventoryLocationTypeResponseBodyUnitOfMeasureType
    : IStringEnum
{
    public static readonly EntityUpdatePartInventoryLocationTypeResponseBodyUnitOfMeasureType Unknown =
        new(Values.Unknown);

    public static readonly EntityUpdatePartInventoryLocationTypeResponseBodyUnitOfMeasureType Each =
        new(Values.Each);

    public static readonly EntityUpdatePartInventoryLocationTypeResponseBodyUnitOfMeasureType Set =
        new(Values.Set);

    public static readonly EntityUpdatePartInventoryLocationTypeResponseBodyUnitOfMeasureType Pack =
        new(Values.Pack);

    public static readonly EntityUpdatePartInventoryLocationTypeResponseBodyUnitOfMeasureType Box =
        new(Values.Box);

    public static readonly EntityUpdatePartInventoryLocationTypeResponseBodyUnitOfMeasureType Pound =
        new(Values.Pound);

    public static readonly EntityUpdatePartInventoryLocationTypeResponseBodyUnitOfMeasureType Kilogram =
        new(Values.Kilogram);

    public static readonly EntityUpdatePartInventoryLocationTypeResponseBodyUnitOfMeasureType Ounce =
        new(Values.Ounce);

    public static readonly EntityUpdatePartInventoryLocationTypeResponseBodyUnitOfMeasureType Liter =
        new(Values.Liter);

    public static readonly EntityUpdatePartInventoryLocationTypeResponseBodyUnitOfMeasureType Milliliter =
        new(Values.Milliliter);

    public static readonly EntityUpdatePartInventoryLocationTypeResponseBodyUnitOfMeasureType Gallon =
        new(Values.Gallon);

    public static readonly EntityUpdatePartInventoryLocationTypeResponseBodyUnitOfMeasureType Quart =
        new(Values.Quart);

    public static readonly EntityUpdatePartInventoryLocationTypeResponseBodyUnitOfMeasureType FluidOunce =
        new(Values.FluidOunce);

    public static readonly EntityUpdatePartInventoryLocationTypeResponseBodyUnitOfMeasureType Inch =
        new(Values.Inch);

    public static readonly EntityUpdatePartInventoryLocationTypeResponseBodyUnitOfMeasureType Foot =
        new(Values.Foot);

    public static readonly EntityUpdatePartInventoryLocationTypeResponseBodyUnitOfMeasureType Meter =
        new(Values.Meter);

    public static readonly EntityUpdatePartInventoryLocationTypeResponseBodyUnitOfMeasureType Yard =
        new(Values.Yard);

    public static readonly EntityUpdatePartInventoryLocationTypeResponseBodyUnitOfMeasureType SquareFoot =
        new(Values.SquareFoot);

    public static readonly EntityUpdatePartInventoryLocationTypeResponseBodyUnitOfMeasureType SquareMeter =
        new(Values.SquareMeter);

    public static readonly EntityUpdatePartInventoryLocationTypeResponseBodyUnitOfMeasureType Pint =
        new(Values.Pint);

    public static readonly EntityUpdatePartInventoryLocationTypeResponseBodyUnitOfMeasureType Hundred =
        new(Values.Hundred);

    public static readonly EntityUpdatePartInventoryLocationTypeResponseBodyUnitOfMeasureType Roll =
        new(Values.Roll);

    public EntityUpdatePartInventoryLocationTypeResponseBodyUnitOfMeasureType(string value)
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
    public static EntityUpdatePartInventoryLocationTypeResponseBodyUnitOfMeasureType FromCustom(
        string value
    )
    {
        return new EntityUpdatePartInventoryLocationTypeResponseBodyUnitOfMeasureType(value);
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
        EntityUpdatePartInventoryLocationTypeResponseBodyUnitOfMeasureType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        EntityUpdatePartInventoryLocationTypeResponseBodyUnitOfMeasureType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        EntityUpdatePartInventoryLocationTypeResponseBodyUnitOfMeasureType value
    ) => value.Value;

    public static explicit operator EntityUpdatePartInventoryLocationTypeResponseBodyUnitOfMeasureType(
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
