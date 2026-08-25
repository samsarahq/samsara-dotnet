using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVarianteafe48Db3764TypeResponseBodyUnitOfMeasureType>)
)]
[Serializable]
public readonly record struct UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVarianteafe48Db3764TypeResponseBodyUnitOfMeasureType
    : IStringEnum
{
    public static readonly UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVarianteafe48Db3764TypeResponseBodyUnitOfMeasureType Unknown =
        new(Values.Unknown);

    public static readonly UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVarianteafe48Db3764TypeResponseBodyUnitOfMeasureType Each =
        new(Values.Each);

    public static readonly UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVarianteafe48Db3764TypeResponseBodyUnitOfMeasureType Set =
        new(Values.Set);

    public static readonly UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVarianteafe48Db3764TypeResponseBodyUnitOfMeasureType Pack =
        new(Values.Pack);

    public static readonly UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVarianteafe48Db3764TypeResponseBodyUnitOfMeasureType Box =
        new(Values.Box);

    public static readonly UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVarianteafe48Db3764TypeResponseBodyUnitOfMeasureType Pound =
        new(Values.Pound);

    public static readonly UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVarianteafe48Db3764TypeResponseBodyUnitOfMeasureType Kilogram =
        new(Values.Kilogram);

    public static readonly UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVarianteafe48Db3764TypeResponseBodyUnitOfMeasureType Ounce =
        new(Values.Ounce);

    public static readonly UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVarianteafe48Db3764TypeResponseBodyUnitOfMeasureType Liter =
        new(Values.Liter);

    public static readonly UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVarianteafe48Db3764TypeResponseBodyUnitOfMeasureType Milliliter =
        new(Values.Milliliter);

    public static readonly UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVarianteafe48Db3764TypeResponseBodyUnitOfMeasureType Gallon =
        new(Values.Gallon);

    public static readonly UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVarianteafe48Db3764TypeResponseBodyUnitOfMeasureType Quart =
        new(Values.Quart);

    public static readonly UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVarianteafe48Db3764TypeResponseBodyUnitOfMeasureType FluidOunce =
        new(Values.FluidOunce);

    public static readonly UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVarianteafe48Db3764TypeResponseBodyUnitOfMeasureType Inch =
        new(Values.Inch);

    public static readonly UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVarianteafe48Db3764TypeResponseBodyUnitOfMeasureType Foot =
        new(Values.Foot);

    public static readonly UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVarianteafe48Db3764TypeResponseBodyUnitOfMeasureType Meter =
        new(Values.Meter);

    public static readonly UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVarianteafe48Db3764TypeResponseBodyUnitOfMeasureType Yard =
        new(Values.Yard);

    public static readonly UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVarianteafe48Db3764TypeResponseBodyUnitOfMeasureType SquareFoot =
        new(Values.SquareFoot);

    public static readonly UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVarianteafe48Db3764TypeResponseBodyUnitOfMeasureType SquareMeter =
        new(Values.SquareMeter);

    public static readonly UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVarianteafe48Db3764TypeResponseBodyUnitOfMeasureType Pint =
        new(Values.Pint);

    public static readonly UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVarianteafe48Db3764TypeResponseBodyUnitOfMeasureType Hundred =
        new(Values.Hundred);

    public static readonly UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVarianteafe48Db3764TypeResponseBodyUnitOfMeasureType Roll =
        new(Values.Roll);

    public UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVarianteafe48Db3764TypeResponseBodyUnitOfMeasureType(
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
    public static UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVarianteafe48Db3764TypeResponseBodyUnitOfMeasureType FromCustom(
        string value
    )
    {
        return new UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVarianteafe48Db3764TypeResponseBodyUnitOfMeasureType(
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
        UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVarianteafe48Db3764TypeResponseBodyUnitOfMeasureType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVarianteafe48Db3764TypeResponseBodyUnitOfMeasureType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVarianteafe48Db3764TypeResponseBodyUnitOfMeasureType value
    ) => value.Value;

    public static explicit operator UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVarianteafe48Db3764TypeResponseBodyUnitOfMeasureType(
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
