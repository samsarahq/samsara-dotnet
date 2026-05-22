using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<PreferredStationDiscountResponseResponseBodyDiscountType>)
)]
[Serializable]
public readonly record struct PreferredStationDiscountResponseResponseBodyDiscountType : IStringEnum
{
    public static readonly PreferredStationDiscountResponseResponseBodyDiscountType CentsPerUnit =
        new(Values.CentsPerUnit);

    public static readonly PreferredStationDiscountResponseResponseBodyDiscountType Percentage =
        new(Values.Percentage);

    public static readonly PreferredStationDiscountResponseResponseBodyDiscountType FixedPrice =
        new(Values.FixedPrice);

    public static readonly PreferredStationDiscountResponseResponseBodyDiscountType Unknown = new(
        Values.Unknown
    );

    public PreferredStationDiscountResponseResponseBodyDiscountType(string value)
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
    public static PreferredStationDiscountResponseResponseBodyDiscountType FromCustom(string value)
    {
        return new PreferredStationDiscountResponseResponseBodyDiscountType(value);
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
        PreferredStationDiscountResponseResponseBodyDiscountType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PreferredStationDiscountResponseResponseBodyDiscountType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PreferredStationDiscountResponseResponseBodyDiscountType value
    ) => value.Value;

    public static explicit operator PreferredStationDiscountResponseResponseBodyDiscountType(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string CentsPerUnit = "centsPerUnit";

        public const string Percentage = "percentage";

        public const string FixedPrice = "fixedPrice";

        public const string Unknown = "unknown";
    }
}
