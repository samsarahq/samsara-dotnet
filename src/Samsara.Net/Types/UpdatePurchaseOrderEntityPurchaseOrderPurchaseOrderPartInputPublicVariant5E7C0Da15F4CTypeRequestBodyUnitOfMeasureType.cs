using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariant5E7C0Da15F4CTypeRequestBodyUnitOfMeasureType>)
)]
[Serializable]
public readonly record struct UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariant5E7C0Da15F4CTypeRequestBodyUnitOfMeasureType
    : IStringEnum
{
    public static readonly UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariant5E7C0Da15F4CTypeRequestBodyUnitOfMeasureType Unknown =
        new(Values.Unknown);

    public static readonly UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariant5E7C0Da15F4CTypeRequestBodyUnitOfMeasureType Each =
        new(Values.Each);

    public static readonly UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariant5E7C0Da15F4CTypeRequestBodyUnitOfMeasureType Set =
        new(Values.Set);

    public static readonly UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariant5E7C0Da15F4CTypeRequestBodyUnitOfMeasureType Pack =
        new(Values.Pack);

    public static readonly UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariant5E7C0Da15F4CTypeRequestBodyUnitOfMeasureType Box =
        new(Values.Box);

    public static readonly UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariant5E7C0Da15F4CTypeRequestBodyUnitOfMeasureType Pound =
        new(Values.Pound);

    public static readonly UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariant5E7C0Da15F4CTypeRequestBodyUnitOfMeasureType Kilogram =
        new(Values.Kilogram);

    public static readonly UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariant5E7C0Da15F4CTypeRequestBodyUnitOfMeasureType Ounce =
        new(Values.Ounce);

    public static readonly UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariant5E7C0Da15F4CTypeRequestBodyUnitOfMeasureType Liter =
        new(Values.Liter);

    public static readonly UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariant5E7C0Da15F4CTypeRequestBodyUnitOfMeasureType Milliliter =
        new(Values.Milliliter);

    public static readonly UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariant5E7C0Da15F4CTypeRequestBodyUnitOfMeasureType Gallon =
        new(Values.Gallon);

    public static readonly UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariant5E7C0Da15F4CTypeRequestBodyUnitOfMeasureType Quart =
        new(Values.Quart);

    public static readonly UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariant5E7C0Da15F4CTypeRequestBodyUnitOfMeasureType FluidOunce =
        new(Values.FluidOunce);

    public static readonly UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariant5E7C0Da15F4CTypeRequestBodyUnitOfMeasureType Inch =
        new(Values.Inch);

    public static readonly UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariant5E7C0Da15F4CTypeRequestBodyUnitOfMeasureType Foot =
        new(Values.Foot);

    public static readonly UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariant5E7C0Da15F4CTypeRequestBodyUnitOfMeasureType Meter =
        new(Values.Meter);

    public static readonly UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariant5E7C0Da15F4CTypeRequestBodyUnitOfMeasureType Yard =
        new(Values.Yard);

    public static readonly UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariant5E7C0Da15F4CTypeRequestBodyUnitOfMeasureType SquareFoot =
        new(Values.SquareFoot);

    public static readonly UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariant5E7C0Da15F4CTypeRequestBodyUnitOfMeasureType SquareMeter =
        new(Values.SquareMeter);

    public static readonly UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariant5E7C0Da15F4CTypeRequestBodyUnitOfMeasureType Pint =
        new(Values.Pint);

    public static readonly UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariant5E7C0Da15F4CTypeRequestBodyUnitOfMeasureType Hundred =
        new(Values.Hundred);

    public static readonly UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariant5E7C0Da15F4CTypeRequestBodyUnitOfMeasureType Roll =
        new(Values.Roll);

    public UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariant5E7C0Da15F4CTypeRequestBodyUnitOfMeasureType(
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
    public static UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariant5E7C0Da15F4CTypeRequestBodyUnitOfMeasureType FromCustom(
        string value
    )
    {
        return new UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariant5E7C0Da15F4CTypeRequestBodyUnitOfMeasureType(
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
        UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariant5E7C0Da15F4CTypeRequestBodyUnitOfMeasureType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariant5E7C0Da15F4CTypeRequestBodyUnitOfMeasureType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariant5E7C0Da15F4CTypeRequestBodyUnitOfMeasureType value
    ) => value.Value;

    public static explicit operator UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariant5E7C0Da15F4CTypeRequestBodyUnitOfMeasureType(
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
