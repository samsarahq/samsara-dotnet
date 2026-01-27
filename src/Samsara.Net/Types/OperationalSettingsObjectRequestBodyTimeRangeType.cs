using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<OperationalSettingsObjectRequestBodyTimeRangeType>))]
[Serializable]
public readonly record struct OperationalSettingsObjectRequestBodyTimeRangeType : IStringEnum
{
    public static readonly OperationalSettingsObjectRequestBodyTimeRangeType ActiveBetween = new(
        Values.ActiveBetween
    );

    public static readonly OperationalSettingsObjectRequestBodyTimeRangeType InactiveBetween = new(
        Values.InactiveBetween
    );

    public OperationalSettingsObjectRequestBodyTimeRangeType(string value)
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
    public static OperationalSettingsObjectRequestBodyTimeRangeType FromCustom(string value)
    {
        return new OperationalSettingsObjectRequestBodyTimeRangeType(value);
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
        OperationalSettingsObjectRequestBodyTimeRangeType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        OperationalSettingsObjectRequestBodyTimeRangeType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        OperationalSettingsObjectRequestBodyTimeRangeType value
    ) => value.Value;

    public static explicit operator OperationalSettingsObjectRequestBodyTimeRangeType(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string ActiveBetween = "activeBetween";

        public const string InactiveBetween = "inactiveBetween";
    }
}
