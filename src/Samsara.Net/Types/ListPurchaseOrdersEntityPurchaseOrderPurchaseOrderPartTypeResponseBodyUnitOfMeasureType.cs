using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<ListPurchaseOrdersEntityPurchaseOrderPurchaseOrderPartTypeResponseBodyUnitOfMeasureType>)
)]
[Serializable]
public readonly record struct ListPurchaseOrdersEntityPurchaseOrderPurchaseOrderPartTypeResponseBodyUnitOfMeasureType
    : IStringEnum
{
    public static readonly ListPurchaseOrdersEntityPurchaseOrderPurchaseOrderPartTypeResponseBodyUnitOfMeasureType Unknown =
        new(Values.Unknown);

    public static readonly ListPurchaseOrdersEntityPurchaseOrderPurchaseOrderPartTypeResponseBodyUnitOfMeasureType Each =
        new(Values.Each);

    public static readonly ListPurchaseOrdersEntityPurchaseOrderPurchaseOrderPartTypeResponseBodyUnitOfMeasureType Set =
        new(Values.Set);

    public static readonly ListPurchaseOrdersEntityPurchaseOrderPurchaseOrderPartTypeResponseBodyUnitOfMeasureType Pack =
        new(Values.Pack);

    public static readonly ListPurchaseOrdersEntityPurchaseOrderPurchaseOrderPartTypeResponseBodyUnitOfMeasureType Box =
        new(Values.Box);

    public static readonly ListPurchaseOrdersEntityPurchaseOrderPurchaseOrderPartTypeResponseBodyUnitOfMeasureType Pound =
        new(Values.Pound);

    public static readonly ListPurchaseOrdersEntityPurchaseOrderPurchaseOrderPartTypeResponseBodyUnitOfMeasureType Kilogram =
        new(Values.Kilogram);

    public static readonly ListPurchaseOrdersEntityPurchaseOrderPurchaseOrderPartTypeResponseBodyUnitOfMeasureType Ounce =
        new(Values.Ounce);

    public static readonly ListPurchaseOrdersEntityPurchaseOrderPurchaseOrderPartTypeResponseBodyUnitOfMeasureType Liter =
        new(Values.Liter);

    public static readonly ListPurchaseOrdersEntityPurchaseOrderPurchaseOrderPartTypeResponseBodyUnitOfMeasureType Milliliter =
        new(Values.Milliliter);

    public static readonly ListPurchaseOrdersEntityPurchaseOrderPurchaseOrderPartTypeResponseBodyUnitOfMeasureType Gallon =
        new(Values.Gallon);

    public static readonly ListPurchaseOrdersEntityPurchaseOrderPurchaseOrderPartTypeResponseBodyUnitOfMeasureType Quart =
        new(Values.Quart);

    public static readonly ListPurchaseOrdersEntityPurchaseOrderPurchaseOrderPartTypeResponseBodyUnitOfMeasureType FluidOunce =
        new(Values.FluidOunce);

    public static readonly ListPurchaseOrdersEntityPurchaseOrderPurchaseOrderPartTypeResponseBodyUnitOfMeasureType Inch =
        new(Values.Inch);

    public static readonly ListPurchaseOrdersEntityPurchaseOrderPurchaseOrderPartTypeResponseBodyUnitOfMeasureType Foot =
        new(Values.Foot);

    public static readonly ListPurchaseOrdersEntityPurchaseOrderPurchaseOrderPartTypeResponseBodyUnitOfMeasureType Meter =
        new(Values.Meter);

    public static readonly ListPurchaseOrdersEntityPurchaseOrderPurchaseOrderPartTypeResponseBodyUnitOfMeasureType Yard =
        new(Values.Yard);

    public static readonly ListPurchaseOrdersEntityPurchaseOrderPurchaseOrderPartTypeResponseBodyUnitOfMeasureType SquareFoot =
        new(Values.SquareFoot);

    public static readonly ListPurchaseOrdersEntityPurchaseOrderPurchaseOrderPartTypeResponseBodyUnitOfMeasureType SquareMeter =
        new(Values.SquareMeter);

    public static readonly ListPurchaseOrdersEntityPurchaseOrderPurchaseOrderPartTypeResponseBodyUnitOfMeasureType Pint =
        new(Values.Pint);

    public static readonly ListPurchaseOrdersEntityPurchaseOrderPurchaseOrderPartTypeResponseBodyUnitOfMeasureType Hundred =
        new(Values.Hundred);

    public static readonly ListPurchaseOrdersEntityPurchaseOrderPurchaseOrderPartTypeResponseBodyUnitOfMeasureType Roll =
        new(Values.Roll);

    public ListPurchaseOrdersEntityPurchaseOrderPurchaseOrderPartTypeResponseBodyUnitOfMeasureType(
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
    public static ListPurchaseOrdersEntityPurchaseOrderPurchaseOrderPartTypeResponseBodyUnitOfMeasureType FromCustom(
        string value
    )
    {
        return new ListPurchaseOrdersEntityPurchaseOrderPurchaseOrderPartTypeResponseBodyUnitOfMeasureType(
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
        ListPurchaseOrdersEntityPurchaseOrderPurchaseOrderPartTypeResponseBodyUnitOfMeasureType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ListPurchaseOrdersEntityPurchaseOrderPurchaseOrderPartTypeResponseBodyUnitOfMeasureType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        ListPurchaseOrdersEntityPurchaseOrderPurchaseOrderPartTypeResponseBodyUnitOfMeasureType value
    ) => value.Value;

    public static explicit operator ListPurchaseOrdersEntityPurchaseOrderPurchaseOrderPartTypeResponseBodyUnitOfMeasureType(
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
