using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVariant21Eb2846219ETypeResponseBodyUnitOfMeasureType>)
)]
[Serializable]
public readonly record struct CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVariant21Eb2846219ETypeResponseBodyUnitOfMeasureType
    : IStringEnum
{
    public static readonly CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVariant21Eb2846219ETypeResponseBodyUnitOfMeasureType Unknown =
        new(Values.Unknown);

    public static readonly CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVariant21Eb2846219ETypeResponseBodyUnitOfMeasureType Each =
        new(Values.Each);

    public static readonly CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVariant21Eb2846219ETypeResponseBodyUnitOfMeasureType Set =
        new(Values.Set);

    public static readonly CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVariant21Eb2846219ETypeResponseBodyUnitOfMeasureType Pack =
        new(Values.Pack);

    public static readonly CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVariant21Eb2846219ETypeResponseBodyUnitOfMeasureType Box =
        new(Values.Box);

    public static readonly CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVariant21Eb2846219ETypeResponseBodyUnitOfMeasureType Pound =
        new(Values.Pound);

    public static readonly CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVariant21Eb2846219ETypeResponseBodyUnitOfMeasureType Kilogram =
        new(Values.Kilogram);

    public static readonly CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVariant21Eb2846219ETypeResponseBodyUnitOfMeasureType Ounce =
        new(Values.Ounce);

    public static readonly CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVariant21Eb2846219ETypeResponseBodyUnitOfMeasureType Liter =
        new(Values.Liter);

    public static readonly CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVariant21Eb2846219ETypeResponseBodyUnitOfMeasureType Milliliter =
        new(Values.Milliliter);

    public static readonly CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVariant21Eb2846219ETypeResponseBodyUnitOfMeasureType Gallon =
        new(Values.Gallon);

    public static readonly CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVariant21Eb2846219ETypeResponseBodyUnitOfMeasureType Quart =
        new(Values.Quart);

    public static readonly CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVariant21Eb2846219ETypeResponseBodyUnitOfMeasureType FluidOunce =
        new(Values.FluidOunce);

    public static readonly CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVariant21Eb2846219ETypeResponseBodyUnitOfMeasureType Inch =
        new(Values.Inch);

    public static readonly CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVariant21Eb2846219ETypeResponseBodyUnitOfMeasureType Foot =
        new(Values.Foot);

    public static readonly CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVariant21Eb2846219ETypeResponseBodyUnitOfMeasureType Meter =
        new(Values.Meter);

    public static readonly CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVariant21Eb2846219ETypeResponseBodyUnitOfMeasureType Yard =
        new(Values.Yard);

    public static readonly CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVariant21Eb2846219ETypeResponseBodyUnitOfMeasureType SquareFoot =
        new(Values.SquareFoot);

    public static readonly CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVariant21Eb2846219ETypeResponseBodyUnitOfMeasureType SquareMeter =
        new(Values.SquareMeter);

    public static readonly CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVariant21Eb2846219ETypeResponseBodyUnitOfMeasureType Pint =
        new(Values.Pint);

    public static readonly CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVariant21Eb2846219ETypeResponseBodyUnitOfMeasureType Hundred =
        new(Values.Hundred);

    public static readonly CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVariant21Eb2846219ETypeResponseBodyUnitOfMeasureType Roll =
        new(Values.Roll);

    public CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVariant21Eb2846219ETypeResponseBodyUnitOfMeasureType(
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
    public static CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVariant21Eb2846219ETypeResponseBodyUnitOfMeasureType FromCustom(
        string value
    )
    {
        return new CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVariant21Eb2846219ETypeResponseBodyUnitOfMeasureType(
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
        CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVariant21Eb2846219ETypeResponseBodyUnitOfMeasureType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVariant21Eb2846219ETypeResponseBodyUnitOfMeasureType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVariant21Eb2846219ETypeResponseBodyUnitOfMeasureType value
    ) => value.Value;

    public static explicit operator CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVariant21Eb2846219ETypeResponseBodyUnitOfMeasureType(
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
