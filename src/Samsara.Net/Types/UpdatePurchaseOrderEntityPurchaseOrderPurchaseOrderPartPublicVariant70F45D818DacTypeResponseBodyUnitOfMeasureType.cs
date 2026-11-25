using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVariant70F45D818DacTypeResponseBodyUnitOfMeasureType>)
)]
[Serializable]
public readonly record struct UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVariant70F45D818DacTypeResponseBodyUnitOfMeasureType
    : IStringEnum
{
    public static readonly UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVariant70F45D818DacTypeResponseBodyUnitOfMeasureType Unknown =
        new(Values.Unknown);

    public static readonly UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVariant70F45D818DacTypeResponseBodyUnitOfMeasureType Each =
        new(Values.Each);

    public static readonly UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVariant70F45D818DacTypeResponseBodyUnitOfMeasureType Set =
        new(Values.Set);

    public static readonly UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVariant70F45D818DacTypeResponseBodyUnitOfMeasureType Pack =
        new(Values.Pack);

    public static readonly UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVariant70F45D818DacTypeResponseBodyUnitOfMeasureType Box =
        new(Values.Box);

    public static readonly UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVariant70F45D818DacTypeResponseBodyUnitOfMeasureType Pound =
        new(Values.Pound);

    public static readonly UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVariant70F45D818DacTypeResponseBodyUnitOfMeasureType Kilogram =
        new(Values.Kilogram);

    public static readonly UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVariant70F45D818DacTypeResponseBodyUnitOfMeasureType Ounce =
        new(Values.Ounce);

    public static readonly UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVariant70F45D818DacTypeResponseBodyUnitOfMeasureType Liter =
        new(Values.Liter);

    public static readonly UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVariant70F45D818DacTypeResponseBodyUnitOfMeasureType Milliliter =
        new(Values.Milliliter);

    public static readonly UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVariant70F45D818DacTypeResponseBodyUnitOfMeasureType Gallon =
        new(Values.Gallon);

    public static readonly UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVariant70F45D818DacTypeResponseBodyUnitOfMeasureType Quart =
        new(Values.Quart);

    public static readonly UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVariant70F45D818DacTypeResponseBodyUnitOfMeasureType FluidOunce =
        new(Values.FluidOunce);

    public static readonly UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVariant70F45D818DacTypeResponseBodyUnitOfMeasureType Inch =
        new(Values.Inch);

    public static readonly UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVariant70F45D818DacTypeResponseBodyUnitOfMeasureType Foot =
        new(Values.Foot);

    public static readonly UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVariant70F45D818DacTypeResponseBodyUnitOfMeasureType Meter =
        new(Values.Meter);

    public static readonly UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVariant70F45D818DacTypeResponseBodyUnitOfMeasureType Yard =
        new(Values.Yard);

    public static readonly UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVariant70F45D818DacTypeResponseBodyUnitOfMeasureType SquareFoot =
        new(Values.SquareFoot);

    public static readonly UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVariant70F45D818DacTypeResponseBodyUnitOfMeasureType SquareMeter =
        new(Values.SquareMeter);

    public static readonly UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVariant70F45D818DacTypeResponseBodyUnitOfMeasureType Pint =
        new(Values.Pint);

    public static readonly UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVariant70F45D818DacTypeResponseBodyUnitOfMeasureType Hundred =
        new(Values.Hundred);

    public static readonly UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVariant70F45D818DacTypeResponseBodyUnitOfMeasureType Roll =
        new(Values.Roll);

    public UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVariant70F45D818DacTypeResponseBodyUnitOfMeasureType(
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
    public static UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVariant70F45D818DacTypeResponseBodyUnitOfMeasureType FromCustom(
        string value
    )
    {
        return new UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVariant70F45D818DacTypeResponseBodyUnitOfMeasureType(
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
        UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVariant70F45D818DacTypeResponseBodyUnitOfMeasureType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVariant70F45D818DacTypeResponseBodyUnitOfMeasureType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVariant70F45D818DacTypeResponseBodyUnitOfMeasureType value
    ) => value.Value;

    public static explicit operator UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVariant70F45D818DacTypeResponseBodyUnitOfMeasureType(
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
