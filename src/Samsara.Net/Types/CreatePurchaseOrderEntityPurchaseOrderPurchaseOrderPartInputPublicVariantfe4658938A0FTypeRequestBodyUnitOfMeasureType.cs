using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariantfe4658938A0FTypeRequestBodyUnitOfMeasureType>)
)]
[Serializable]
public readonly record struct CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariantfe4658938A0FTypeRequestBodyUnitOfMeasureType
    : IStringEnum
{
    public static readonly CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariantfe4658938A0FTypeRequestBodyUnitOfMeasureType Unknown =
        new(Values.Unknown);

    public static readonly CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariantfe4658938A0FTypeRequestBodyUnitOfMeasureType Each =
        new(Values.Each);

    public static readonly CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariantfe4658938A0FTypeRequestBodyUnitOfMeasureType Set =
        new(Values.Set);

    public static readonly CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariantfe4658938A0FTypeRequestBodyUnitOfMeasureType Pack =
        new(Values.Pack);

    public static readonly CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariantfe4658938A0FTypeRequestBodyUnitOfMeasureType Box =
        new(Values.Box);

    public static readonly CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariantfe4658938A0FTypeRequestBodyUnitOfMeasureType Pound =
        new(Values.Pound);

    public static readonly CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariantfe4658938A0FTypeRequestBodyUnitOfMeasureType Kilogram =
        new(Values.Kilogram);

    public static readonly CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariantfe4658938A0FTypeRequestBodyUnitOfMeasureType Ounce =
        new(Values.Ounce);

    public static readonly CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariantfe4658938A0FTypeRequestBodyUnitOfMeasureType Liter =
        new(Values.Liter);

    public static readonly CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariantfe4658938A0FTypeRequestBodyUnitOfMeasureType Milliliter =
        new(Values.Milliliter);

    public static readonly CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariantfe4658938A0FTypeRequestBodyUnitOfMeasureType Gallon =
        new(Values.Gallon);

    public static readonly CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariantfe4658938A0FTypeRequestBodyUnitOfMeasureType Quart =
        new(Values.Quart);

    public static readonly CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariantfe4658938A0FTypeRequestBodyUnitOfMeasureType FluidOunce =
        new(Values.FluidOunce);

    public static readonly CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariantfe4658938A0FTypeRequestBodyUnitOfMeasureType Inch =
        new(Values.Inch);

    public static readonly CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariantfe4658938A0FTypeRequestBodyUnitOfMeasureType Foot =
        new(Values.Foot);

    public static readonly CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariantfe4658938A0FTypeRequestBodyUnitOfMeasureType Meter =
        new(Values.Meter);

    public static readonly CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariantfe4658938A0FTypeRequestBodyUnitOfMeasureType Yard =
        new(Values.Yard);

    public static readonly CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariantfe4658938A0FTypeRequestBodyUnitOfMeasureType SquareFoot =
        new(Values.SquareFoot);

    public static readonly CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariantfe4658938A0FTypeRequestBodyUnitOfMeasureType SquareMeter =
        new(Values.SquareMeter);

    public static readonly CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariantfe4658938A0FTypeRequestBodyUnitOfMeasureType Pint =
        new(Values.Pint);

    public static readonly CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariantfe4658938A0FTypeRequestBodyUnitOfMeasureType Hundred =
        new(Values.Hundred);

    public static readonly CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariantfe4658938A0FTypeRequestBodyUnitOfMeasureType Roll =
        new(Values.Roll);

    public CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariantfe4658938A0FTypeRequestBodyUnitOfMeasureType(
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
    public static CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariantfe4658938A0FTypeRequestBodyUnitOfMeasureType FromCustom(
        string value
    )
    {
        return new CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariantfe4658938A0FTypeRequestBodyUnitOfMeasureType(
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
        CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariantfe4658938A0FTypeRequestBodyUnitOfMeasureType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariantfe4658938A0FTypeRequestBodyUnitOfMeasureType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariantfe4658938A0FTypeRequestBodyUnitOfMeasureType value
    ) => value.Value;

    public static explicit operator CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariantfe4658938A0FTypeRequestBodyUnitOfMeasureType(
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
