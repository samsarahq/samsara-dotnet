using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<OperationalSettingsObjectResponseBodyTimeRangeType>))]
[Serializable]
public readonly record struct OperationalSettingsObjectResponseBodyTimeRangeType : IStringEnum
{
    public static readonly OperationalSettingsObjectResponseBodyTimeRangeType ActiveBetween = new(
        Values.ActiveBetween
    );

    public static readonly OperationalSettingsObjectResponseBodyTimeRangeType InactiveBetween = new(
        Values.InactiveBetween
    );

    public OperationalSettingsObjectResponseBodyTimeRangeType(string value)
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
    public static OperationalSettingsObjectResponseBodyTimeRangeType FromCustom(string value)
    {
        return new OperationalSettingsObjectResponseBodyTimeRangeType(value);
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
        OperationalSettingsObjectResponseBodyTimeRangeType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        OperationalSettingsObjectResponseBodyTimeRangeType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        OperationalSettingsObjectResponseBodyTimeRangeType value
    ) => value.Value;

    public static explicit operator OperationalSettingsObjectResponseBodyTimeRangeType(
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
