using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariant63E9Febe395ETypeRequestBodyUnitOfMeasureType>)
)]
[Serializable]
public readonly record struct CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariant63E9Febe395ETypeRequestBodyUnitOfMeasureType
    : IStringEnum
{
    public static readonly CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariant63E9Febe395ETypeRequestBodyUnitOfMeasureType Unknown =
        new(Values.Unknown);

    public static readonly CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariant63E9Febe395ETypeRequestBodyUnitOfMeasureType Each =
        new(Values.Each);

    public static readonly CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariant63E9Febe395ETypeRequestBodyUnitOfMeasureType Set =
        new(Values.Set);

    public static readonly CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariant63E9Febe395ETypeRequestBodyUnitOfMeasureType Pack =
        new(Values.Pack);

    public static readonly CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariant63E9Febe395ETypeRequestBodyUnitOfMeasureType Box =
        new(Values.Box);

    public static readonly CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariant63E9Febe395ETypeRequestBodyUnitOfMeasureType Pound =
        new(Values.Pound);

    public static readonly CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariant63E9Febe395ETypeRequestBodyUnitOfMeasureType Kilogram =
        new(Values.Kilogram);

    public static readonly CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariant63E9Febe395ETypeRequestBodyUnitOfMeasureType Ounce =
        new(Values.Ounce);

    public static readonly CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariant63E9Febe395ETypeRequestBodyUnitOfMeasureType Liter =
        new(Values.Liter);

    public static readonly CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariant63E9Febe395ETypeRequestBodyUnitOfMeasureType Milliliter =
        new(Values.Milliliter);

    public static readonly CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariant63E9Febe395ETypeRequestBodyUnitOfMeasureType Gallon =
        new(Values.Gallon);

    public static readonly CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariant63E9Febe395ETypeRequestBodyUnitOfMeasureType Quart =
        new(Values.Quart);

    public static readonly CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariant63E9Febe395ETypeRequestBodyUnitOfMeasureType FluidOunce =
        new(Values.FluidOunce);

    public static readonly CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariant63E9Febe395ETypeRequestBodyUnitOfMeasureType Inch =
        new(Values.Inch);

    public static readonly CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariant63E9Febe395ETypeRequestBodyUnitOfMeasureType Foot =
        new(Values.Foot);

    public static readonly CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariant63E9Febe395ETypeRequestBodyUnitOfMeasureType Meter =
        new(Values.Meter);

    public static readonly CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariant63E9Febe395ETypeRequestBodyUnitOfMeasureType Yard =
        new(Values.Yard);

    public static readonly CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariant63E9Febe395ETypeRequestBodyUnitOfMeasureType SquareFoot =
        new(Values.SquareFoot);

    public static readonly CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariant63E9Febe395ETypeRequestBodyUnitOfMeasureType SquareMeter =
        new(Values.SquareMeter);

    public static readonly CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariant63E9Febe395ETypeRequestBodyUnitOfMeasureType Pint =
        new(Values.Pint);

    public static readonly CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariant63E9Febe395ETypeRequestBodyUnitOfMeasureType Hundred =
        new(Values.Hundred);

    public static readonly CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariant63E9Febe395ETypeRequestBodyUnitOfMeasureType Roll =
        new(Values.Roll);

    public CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariant63E9Febe395ETypeRequestBodyUnitOfMeasureType(
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
    public static CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariant63E9Febe395ETypeRequestBodyUnitOfMeasureType FromCustom(
        string value
    )
    {
        return new CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariant63E9Febe395ETypeRequestBodyUnitOfMeasureType(
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
        CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariant63E9Febe395ETypeRequestBodyUnitOfMeasureType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariant63E9Febe395ETypeRequestBodyUnitOfMeasureType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariant63E9Febe395ETypeRequestBodyUnitOfMeasureType value
    ) => value.Value;

    public static explicit operator CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariant63E9Febe395ETypeRequestBodyUnitOfMeasureType(
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
