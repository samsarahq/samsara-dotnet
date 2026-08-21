using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariant1A94E81632EaTypeRequestBodyUnitOfMeasureType>)
)]
[Serializable]
public readonly record struct UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariant1A94E81632EaTypeRequestBodyUnitOfMeasureType
    : IStringEnum
{
    public static readonly UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariant1A94E81632EaTypeRequestBodyUnitOfMeasureType Unknown =
        new(Values.Unknown);

    public static readonly UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariant1A94E81632EaTypeRequestBodyUnitOfMeasureType Each =
        new(Values.Each);

    public static readonly UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariant1A94E81632EaTypeRequestBodyUnitOfMeasureType Set =
        new(Values.Set);

    public static readonly UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariant1A94E81632EaTypeRequestBodyUnitOfMeasureType Pack =
        new(Values.Pack);

    public static readonly UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariant1A94E81632EaTypeRequestBodyUnitOfMeasureType Box =
        new(Values.Box);

    public static readonly UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariant1A94E81632EaTypeRequestBodyUnitOfMeasureType Pound =
        new(Values.Pound);

    public static readonly UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariant1A94E81632EaTypeRequestBodyUnitOfMeasureType Kilogram =
        new(Values.Kilogram);

    public static readonly UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariant1A94E81632EaTypeRequestBodyUnitOfMeasureType Ounce =
        new(Values.Ounce);

    public static readonly UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariant1A94E81632EaTypeRequestBodyUnitOfMeasureType Liter =
        new(Values.Liter);

    public static readonly UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariant1A94E81632EaTypeRequestBodyUnitOfMeasureType Milliliter =
        new(Values.Milliliter);

    public static readonly UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariant1A94E81632EaTypeRequestBodyUnitOfMeasureType Gallon =
        new(Values.Gallon);

    public static readonly UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariant1A94E81632EaTypeRequestBodyUnitOfMeasureType Quart =
        new(Values.Quart);

    public static readonly UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariant1A94E81632EaTypeRequestBodyUnitOfMeasureType FluidOunce =
        new(Values.FluidOunce);

    public static readonly UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariant1A94E81632EaTypeRequestBodyUnitOfMeasureType Inch =
        new(Values.Inch);

    public static readonly UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariant1A94E81632EaTypeRequestBodyUnitOfMeasureType Foot =
        new(Values.Foot);

    public static readonly UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariant1A94E81632EaTypeRequestBodyUnitOfMeasureType Meter =
        new(Values.Meter);

    public static readonly UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariant1A94E81632EaTypeRequestBodyUnitOfMeasureType Yard =
        new(Values.Yard);

    public static readonly UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariant1A94E81632EaTypeRequestBodyUnitOfMeasureType SquareFoot =
        new(Values.SquareFoot);

    public static readonly UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariant1A94E81632EaTypeRequestBodyUnitOfMeasureType SquareMeter =
        new(Values.SquareMeter);

    public static readonly UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariant1A94E81632EaTypeRequestBodyUnitOfMeasureType Pint =
        new(Values.Pint);

    public static readonly UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariant1A94E81632EaTypeRequestBodyUnitOfMeasureType Hundred =
        new(Values.Hundred);

    public static readonly UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariant1A94E81632EaTypeRequestBodyUnitOfMeasureType Roll =
        new(Values.Roll);

    public UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariant1A94E81632EaTypeRequestBodyUnitOfMeasureType(
        string value
    )
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
    public static UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariant1A94E81632EaTypeRequestBodyUnitOfMeasureType FromCustom(
        string value
    )
    {
        return new UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariant1A94E81632EaTypeRequestBodyUnitOfMeasureType(
            value
        );
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
        UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariant1A94E81632EaTypeRequestBodyUnitOfMeasureType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariant1A94E81632EaTypeRequestBodyUnitOfMeasureType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariant1A94E81632EaTypeRequestBodyUnitOfMeasureType value
    ) => value.Value;

    public static explicit operator UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariant1A94E81632EaTypeRequestBodyUnitOfMeasureType(
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
