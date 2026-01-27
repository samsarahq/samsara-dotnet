using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<ForwardCollisionDetectionAlertSettingsObjectResponseBodySensitivity>)
)]
[Serializable]
public readonly record struct ForwardCollisionDetectionAlertSettingsObjectResponseBodySensitivity
    : IStringEnum
{
    public static readonly ForwardCollisionDetectionAlertSettingsObjectResponseBodySensitivity Near =
        new(Values.Near);

    public static readonly ForwardCollisionDetectionAlertSettingsObjectResponseBodySensitivity Medium =
        new(Values.Medium);

    public static readonly ForwardCollisionDetectionAlertSettingsObjectResponseBodySensitivity Far =
        new(Values.Far);

    public ForwardCollisionDetectionAlertSettingsObjectResponseBodySensitivity(string value)
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
    public static ForwardCollisionDetectionAlertSettingsObjectResponseBodySensitivity FromCustom(
        string value
    )
    {
        return new ForwardCollisionDetectionAlertSettingsObjectResponseBodySensitivity(value);
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
        ForwardCollisionDetectionAlertSettingsObjectResponseBodySensitivity value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ForwardCollisionDetectionAlertSettingsObjectResponseBodySensitivity value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        ForwardCollisionDetectionAlertSettingsObjectResponseBodySensitivity value
    ) => value.Value;

    public static explicit operator ForwardCollisionDetectionAlertSettingsObjectResponseBodySensitivity(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Near = "near";

        public const string Medium = "medium";

        public const string Far = "far";
    }
}
