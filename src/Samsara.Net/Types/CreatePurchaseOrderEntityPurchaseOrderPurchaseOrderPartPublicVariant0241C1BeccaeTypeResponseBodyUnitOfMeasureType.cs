using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVariant0241C1BeccaeTypeResponseBodyUnitOfMeasureType>)
)]
[Serializable]
public readonly record struct CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVariant0241C1BeccaeTypeResponseBodyUnitOfMeasureType
    : IStringEnum
{
    public static readonly CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVariant0241C1BeccaeTypeResponseBodyUnitOfMeasureType Unknown =
        new(Values.Unknown);

    public static readonly CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVariant0241C1BeccaeTypeResponseBodyUnitOfMeasureType Each =
        new(Values.Each);

    public static readonly CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVariant0241C1BeccaeTypeResponseBodyUnitOfMeasureType Set =
        new(Values.Set);

    public static readonly CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVariant0241C1BeccaeTypeResponseBodyUnitOfMeasureType Pack =
        new(Values.Pack);

    public static readonly CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVariant0241C1BeccaeTypeResponseBodyUnitOfMeasureType Box =
        new(Values.Box);

    public static readonly CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVariant0241C1BeccaeTypeResponseBodyUnitOfMeasureType Pound =
        new(Values.Pound);

    public static readonly CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVariant0241C1BeccaeTypeResponseBodyUnitOfMeasureType Kilogram =
        new(Values.Kilogram);

    public static readonly CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVariant0241C1BeccaeTypeResponseBodyUnitOfMeasureType Ounce =
        new(Values.Ounce);

    public static readonly CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVariant0241C1BeccaeTypeResponseBodyUnitOfMeasureType Liter =
        new(Values.Liter);

    public static readonly CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVariant0241C1BeccaeTypeResponseBodyUnitOfMeasureType Milliliter =
        new(Values.Milliliter);

    public static readonly CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVariant0241C1BeccaeTypeResponseBodyUnitOfMeasureType Gallon =
        new(Values.Gallon);

    public static readonly CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVariant0241C1BeccaeTypeResponseBodyUnitOfMeasureType Quart =
        new(Values.Quart);

    public static readonly CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVariant0241C1BeccaeTypeResponseBodyUnitOfMeasureType FluidOunce =
        new(Values.FluidOunce);

    public static readonly CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVariant0241C1BeccaeTypeResponseBodyUnitOfMeasureType Inch =
        new(Values.Inch);

    public static readonly CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVariant0241C1BeccaeTypeResponseBodyUnitOfMeasureType Foot =
        new(Values.Foot);

    public static readonly CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVariant0241C1BeccaeTypeResponseBodyUnitOfMeasureType Meter =
        new(Values.Meter);

    public static readonly CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVariant0241C1BeccaeTypeResponseBodyUnitOfMeasureType Yard =
        new(Values.Yard);

    public static readonly CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVariant0241C1BeccaeTypeResponseBodyUnitOfMeasureType SquareFoot =
        new(Values.SquareFoot);

    public static readonly CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVariant0241C1BeccaeTypeResponseBodyUnitOfMeasureType SquareMeter =
        new(Values.SquareMeter);

    public static readonly CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVariant0241C1BeccaeTypeResponseBodyUnitOfMeasureType Pint =
        new(Values.Pint);

    public static readonly CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVariant0241C1BeccaeTypeResponseBodyUnitOfMeasureType Hundred =
        new(Values.Hundred);

    public static readonly CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVariant0241C1BeccaeTypeResponseBodyUnitOfMeasureType Roll =
        new(Values.Roll);

    public CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVariant0241C1BeccaeTypeResponseBodyUnitOfMeasureType(
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
    public static CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVariant0241C1BeccaeTypeResponseBodyUnitOfMeasureType FromCustom(
        string value
    )
    {
        return new CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVariant0241C1BeccaeTypeResponseBodyUnitOfMeasureType(
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
        CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVariant0241C1BeccaeTypeResponseBodyUnitOfMeasureType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVariant0241C1BeccaeTypeResponseBodyUnitOfMeasureType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVariant0241C1BeccaeTypeResponseBodyUnitOfMeasureType value
    ) => value.Value;

    public static explicit operator CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVariant0241C1BeccaeTypeResponseBodyUnitOfMeasureType(
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
