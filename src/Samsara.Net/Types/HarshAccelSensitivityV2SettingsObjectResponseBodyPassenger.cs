using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<HarshAccelSensitivityV2SettingsObjectResponseBodyPassenger>)
)]
[Serializable]
public readonly record struct HarshAccelSensitivityV2SettingsObjectResponseBodyPassenger
    : IStringEnum
{
    public static readonly HarshAccelSensitivityV2SettingsObjectResponseBodyPassenger Unknown = new(
        Values.Unknown
    );

    public static readonly HarshAccelSensitivityV2SettingsObjectResponseBodyPassenger Invalid = new(
        Values.Invalid
    );

    public static readonly HarshAccelSensitivityV2SettingsObjectResponseBodyPassenger Off = new(
        Values.Off
    );

    public static readonly HarshAccelSensitivityV2SettingsObjectResponseBodyPassenger Low = new(
        Values.Low
    );

    public static readonly HarshAccelSensitivityV2SettingsObjectResponseBodyPassenger Normal = new(
        Values.Normal
    );

    public static readonly HarshAccelSensitivityV2SettingsObjectResponseBodyPassenger High = new(
        Values.High
    );

    public HarshAccelSensitivityV2SettingsObjectResponseBodyPassenger(string value)
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
    public static HarshAccelSensitivityV2SettingsObjectResponseBodyPassenger FromCustom(
        string value
    )
    {
        return new HarshAccelSensitivityV2SettingsObjectResponseBodyPassenger(value);
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
        HarshAccelSensitivityV2SettingsObjectResponseBodyPassenger value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        HarshAccelSensitivityV2SettingsObjectResponseBodyPassenger value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        HarshAccelSensitivityV2SettingsObjectResponseBodyPassenger value
    ) => value.Value;

    public static explicit operator HarshAccelSensitivityV2SettingsObjectResponseBodyPassenger(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Unknown = "unknown";

        public const string Invalid = "invalid";

        public const string Off = "off";

        public const string Low = "low";

        public const string Normal = "normal";

        public const string High = "high";
    }
}
