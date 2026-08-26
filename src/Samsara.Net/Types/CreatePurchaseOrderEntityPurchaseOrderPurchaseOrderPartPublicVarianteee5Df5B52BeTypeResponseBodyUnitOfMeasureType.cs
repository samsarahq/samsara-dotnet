using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVarianteee5Df5B52BeTypeResponseBodyUnitOfMeasureType>)
)]
[Serializable]
public readonly record struct CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVarianteee5Df5B52BeTypeResponseBodyUnitOfMeasureType
    : IStringEnum
{
    public static readonly CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVarianteee5Df5B52BeTypeResponseBodyUnitOfMeasureType Unknown =
        new(Values.Unknown);

    public static readonly CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVarianteee5Df5B52BeTypeResponseBodyUnitOfMeasureType Each =
        new(Values.Each);

    public static readonly CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVarianteee5Df5B52BeTypeResponseBodyUnitOfMeasureType Set =
        new(Values.Set);

    public static readonly CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVarianteee5Df5B52BeTypeResponseBodyUnitOfMeasureType Pack =
        new(Values.Pack);

    public static readonly CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVarianteee5Df5B52BeTypeResponseBodyUnitOfMeasureType Box =
        new(Values.Box);

    public static readonly CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVarianteee5Df5B52BeTypeResponseBodyUnitOfMeasureType Pound =
        new(Values.Pound);

    public static readonly CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVarianteee5Df5B52BeTypeResponseBodyUnitOfMeasureType Kilogram =
        new(Values.Kilogram);

    public static readonly CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVarianteee5Df5B52BeTypeResponseBodyUnitOfMeasureType Ounce =
        new(Values.Ounce);

    public static readonly CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVarianteee5Df5B52BeTypeResponseBodyUnitOfMeasureType Liter =
        new(Values.Liter);

    public static readonly CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVarianteee5Df5B52BeTypeResponseBodyUnitOfMeasureType Milliliter =
        new(Values.Milliliter);

    public static readonly CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVarianteee5Df5B52BeTypeResponseBodyUnitOfMeasureType Gallon =
        new(Values.Gallon);

    public static readonly CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVarianteee5Df5B52BeTypeResponseBodyUnitOfMeasureType Quart =
        new(Values.Quart);

    public static readonly CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVarianteee5Df5B52BeTypeResponseBodyUnitOfMeasureType FluidOunce =
        new(Values.FluidOunce);

    public static readonly CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVarianteee5Df5B52BeTypeResponseBodyUnitOfMeasureType Inch =
        new(Values.Inch);

    public static readonly CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVarianteee5Df5B52BeTypeResponseBodyUnitOfMeasureType Foot =
        new(Values.Foot);

    public static readonly CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVarianteee5Df5B52BeTypeResponseBodyUnitOfMeasureType Meter =
        new(Values.Meter);

    public static readonly CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVarianteee5Df5B52BeTypeResponseBodyUnitOfMeasureType Yard =
        new(Values.Yard);

    public static readonly CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVarianteee5Df5B52BeTypeResponseBodyUnitOfMeasureType SquareFoot =
        new(Values.SquareFoot);

    public static readonly CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVarianteee5Df5B52BeTypeResponseBodyUnitOfMeasureType SquareMeter =
        new(Values.SquareMeter);

    public static readonly CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVarianteee5Df5B52BeTypeResponseBodyUnitOfMeasureType Pint =
        new(Values.Pint);

    public static readonly CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVarianteee5Df5B52BeTypeResponseBodyUnitOfMeasureType Hundred =
        new(Values.Hundred);

    public static readonly CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVarianteee5Df5B52BeTypeResponseBodyUnitOfMeasureType Roll =
        new(Values.Roll);

    public CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVarianteee5Df5B52BeTypeResponseBodyUnitOfMeasureType(
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
    public static CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVarianteee5Df5B52BeTypeResponseBodyUnitOfMeasureType FromCustom(
        string value
    )
    {
        return new CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVarianteee5Df5B52BeTypeResponseBodyUnitOfMeasureType(
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
        CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVarianteee5Df5B52BeTypeResponseBodyUnitOfMeasureType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVarianteee5Df5B52BeTypeResponseBodyUnitOfMeasureType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVarianteee5Df5B52BeTypeResponseBodyUnitOfMeasureType value
    ) => value.Value;

    public static explicit operator CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVarianteee5Df5B52BeTypeResponseBodyUnitOfMeasureType(
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
