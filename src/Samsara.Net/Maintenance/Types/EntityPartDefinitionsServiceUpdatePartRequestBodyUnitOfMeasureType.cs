using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Maintenance;

[JsonConverter(
    typeof(StringEnumSerializer<EntityPartDefinitionsServiceUpdatePartRequestBodyUnitOfMeasureType>)
)]
[Serializable]
public readonly record struct EntityPartDefinitionsServiceUpdatePartRequestBodyUnitOfMeasureType
    : IStringEnum
{
    public static readonly EntityPartDefinitionsServiceUpdatePartRequestBodyUnitOfMeasureType Unknown =
        new(Values.Unknown);

    public static readonly EntityPartDefinitionsServiceUpdatePartRequestBodyUnitOfMeasureType Each =
        new(Values.Each);

    public static readonly EntityPartDefinitionsServiceUpdatePartRequestBodyUnitOfMeasureType Set =
        new(Values.Set);

    public static readonly EntityPartDefinitionsServiceUpdatePartRequestBodyUnitOfMeasureType Pack =
        new(Values.Pack);

    public static readonly EntityPartDefinitionsServiceUpdatePartRequestBodyUnitOfMeasureType Box =
        new(Values.Box);

    public static readonly EntityPartDefinitionsServiceUpdatePartRequestBodyUnitOfMeasureType Pound =
        new(Values.Pound);

    public static readonly EntityPartDefinitionsServiceUpdatePartRequestBodyUnitOfMeasureType Kilogram =
        new(Values.Kilogram);

    public static readonly EntityPartDefinitionsServiceUpdatePartRequestBodyUnitOfMeasureType Ounce =
        new(Values.Ounce);

    public static readonly EntityPartDefinitionsServiceUpdatePartRequestBodyUnitOfMeasureType Liter =
        new(Values.Liter);

    public static readonly EntityPartDefinitionsServiceUpdatePartRequestBodyUnitOfMeasureType Milliliter =
        new(Values.Milliliter);

    public static readonly EntityPartDefinitionsServiceUpdatePartRequestBodyUnitOfMeasureType Gallon =
        new(Values.Gallon);

    public static readonly EntityPartDefinitionsServiceUpdatePartRequestBodyUnitOfMeasureType Quart =
        new(Values.Quart);

    public static readonly EntityPartDefinitionsServiceUpdatePartRequestBodyUnitOfMeasureType FluidOunce =
        new(Values.FluidOunce);

    public static readonly EntityPartDefinitionsServiceUpdatePartRequestBodyUnitOfMeasureType Inch =
        new(Values.Inch);

    public static readonly EntityPartDefinitionsServiceUpdatePartRequestBodyUnitOfMeasureType Foot =
        new(Values.Foot);

    public static readonly EntityPartDefinitionsServiceUpdatePartRequestBodyUnitOfMeasureType Meter =
        new(Values.Meter);

    public static readonly EntityPartDefinitionsServiceUpdatePartRequestBodyUnitOfMeasureType Yard =
        new(Values.Yard);

    public static readonly EntityPartDefinitionsServiceUpdatePartRequestBodyUnitOfMeasureType SquareFoot =
        new(Values.SquareFoot);

    public static readonly EntityPartDefinitionsServiceUpdatePartRequestBodyUnitOfMeasureType SquareMeter =
        new(Values.SquareMeter);

    public static readonly EntityPartDefinitionsServiceUpdatePartRequestBodyUnitOfMeasureType Pint =
        new(Values.Pint);

    public static readonly EntityPartDefinitionsServiceUpdatePartRequestBodyUnitOfMeasureType Hundred =
        new(Values.Hundred);

    public static readonly EntityPartDefinitionsServiceUpdatePartRequestBodyUnitOfMeasureType Roll =
        new(Values.Roll);

    public EntityPartDefinitionsServiceUpdatePartRequestBodyUnitOfMeasureType(string value)
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
    public static EntityPartDefinitionsServiceUpdatePartRequestBodyUnitOfMeasureType FromCustom(
        string value
    )
    {
        return new EntityPartDefinitionsServiceUpdatePartRequestBodyUnitOfMeasureType(value);
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
        EntityPartDefinitionsServiceUpdatePartRequestBodyUnitOfMeasureType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        EntityPartDefinitionsServiceUpdatePartRequestBodyUnitOfMeasureType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        EntityPartDefinitionsServiceUpdatePartRequestBodyUnitOfMeasureType value
    ) => value.Value;

    public static explicit operator EntityPartDefinitionsServiceUpdatePartRequestBodyUnitOfMeasureType(
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
