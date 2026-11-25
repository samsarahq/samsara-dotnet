using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariantb86Cbda851C6TypeRequestBodyUnitOfMeasureType>)
)]
[Serializable]
public readonly record struct UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariantb86Cbda851C6TypeRequestBodyUnitOfMeasureType
    : IStringEnum
{
    public static readonly UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariantb86Cbda851C6TypeRequestBodyUnitOfMeasureType Unknown =
        new(Values.Unknown);

    public static readonly UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariantb86Cbda851C6TypeRequestBodyUnitOfMeasureType Each =
        new(Values.Each);

    public static readonly UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariantb86Cbda851C6TypeRequestBodyUnitOfMeasureType Set =
        new(Values.Set);

    public static readonly UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariantb86Cbda851C6TypeRequestBodyUnitOfMeasureType Pack =
        new(Values.Pack);

    public static readonly UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariantb86Cbda851C6TypeRequestBodyUnitOfMeasureType Box =
        new(Values.Box);

    public static readonly UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariantb86Cbda851C6TypeRequestBodyUnitOfMeasureType Pound =
        new(Values.Pound);

    public static readonly UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariantb86Cbda851C6TypeRequestBodyUnitOfMeasureType Kilogram =
        new(Values.Kilogram);

    public static readonly UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariantb86Cbda851C6TypeRequestBodyUnitOfMeasureType Ounce =
        new(Values.Ounce);

    public static readonly UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariantb86Cbda851C6TypeRequestBodyUnitOfMeasureType Liter =
        new(Values.Liter);

    public static readonly UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariantb86Cbda851C6TypeRequestBodyUnitOfMeasureType Milliliter =
        new(Values.Milliliter);

    public static readonly UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariantb86Cbda851C6TypeRequestBodyUnitOfMeasureType Gallon =
        new(Values.Gallon);

    public static readonly UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariantb86Cbda851C6TypeRequestBodyUnitOfMeasureType Quart =
        new(Values.Quart);

    public static readonly UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariantb86Cbda851C6TypeRequestBodyUnitOfMeasureType FluidOunce =
        new(Values.FluidOunce);

    public static readonly UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariantb86Cbda851C6TypeRequestBodyUnitOfMeasureType Inch =
        new(Values.Inch);

    public static readonly UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariantb86Cbda851C6TypeRequestBodyUnitOfMeasureType Foot =
        new(Values.Foot);

    public static readonly UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariantb86Cbda851C6TypeRequestBodyUnitOfMeasureType Meter =
        new(Values.Meter);

    public static readonly UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariantb86Cbda851C6TypeRequestBodyUnitOfMeasureType Yard =
        new(Values.Yard);

    public static readonly UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariantb86Cbda851C6TypeRequestBodyUnitOfMeasureType SquareFoot =
        new(Values.SquareFoot);

    public static readonly UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariantb86Cbda851C6TypeRequestBodyUnitOfMeasureType SquareMeter =
        new(Values.SquareMeter);

    public static readonly UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariantb86Cbda851C6TypeRequestBodyUnitOfMeasureType Pint =
        new(Values.Pint);

    public static readonly UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariantb86Cbda851C6TypeRequestBodyUnitOfMeasureType Hundred =
        new(Values.Hundred);

    public static readonly UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariantb86Cbda851C6TypeRequestBodyUnitOfMeasureType Roll =
        new(Values.Roll);

    public UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariantb86Cbda851C6TypeRequestBodyUnitOfMeasureType(
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
    public static UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariantb86Cbda851C6TypeRequestBodyUnitOfMeasureType FromCustom(
        string value
    )
    {
        return new UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariantb86Cbda851C6TypeRequestBodyUnitOfMeasureType(
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
        UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariantb86Cbda851C6TypeRequestBodyUnitOfMeasureType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariantb86Cbda851C6TypeRequestBodyUnitOfMeasureType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariantb86Cbda851C6TypeRequestBodyUnitOfMeasureType value
    ) => value.Value;

    public static explicit operator UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariantb86Cbda851C6TypeRequestBodyUnitOfMeasureType(
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
