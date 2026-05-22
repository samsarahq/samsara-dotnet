using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<PreferredStationDiscountInputRequestBodyDiscountType>))]
[Serializable]
public readonly record struct PreferredStationDiscountInputRequestBodyDiscountType : IStringEnum
{
    public static readonly PreferredStationDiscountInputRequestBodyDiscountType CentsPerUnit = new(
        Values.CentsPerUnit
    );

    public static readonly PreferredStationDiscountInputRequestBodyDiscountType Percentage = new(
        Values.Percentage
    );

    public static readonly PreferredStationDiscountInputRequestBodyDiscountType FixedPrice = new(
        Values.FixedPrice
    );

    public PreferredStationDiscountInputRequestBodyDiscountType(string value)
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
    public static PreferredStationDiscountInputRequestBodyDiscountType FromCustom(string value)
    {
        return new PreferredStationDiscountInputRequestBodyDiscountType(value);
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
        PreferredStationDiscountInputRequestBodyDiscountType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PreferredStationDiscountInputRequestBodyDiscountType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PreferredStationDiscountInputRequestBodyDiscountType value
    ) => value.Value;

    public static explicit operator PreferredStationDiscountInputRequestBodyDiscountType(
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
    }
}
