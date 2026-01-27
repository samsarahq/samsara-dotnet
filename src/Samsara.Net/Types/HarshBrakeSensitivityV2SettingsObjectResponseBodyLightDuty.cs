using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<HarshBrakeSensitivityV2SettingsObjectResponseBodyLightDuty>)
)]
[Serializable]
public readonly record struct HarshBrakeSensitivityV2SettingsObjectResponseBodyLightDuty
    : IStringEnum
{
    public static readonly HarshBrakeSensitivityV2SettingsObjectResponseBodyLightDuty Unknown = new(
        Values.Unknown
    );

    public static readonly HarshBrakeSensitivityV2SettingsObjectResponseBodyLightDuty Invalid = new(
        Values.Invalid
    );

    public static readonly HarshBrakeSensitivityV2SettingsObjectResponseBodyLightDuty Off = new(
        Values.Off
    );

    public static readonly HarshBrakeSensitivityV2SettingsObjectResponseBodyLightDuty VeryLow = new(
        Values.VeryLow
    );

    public static readonly HarshBrakeSensitivityV2SettingsObjectResponseBodyLightDuty Low = new(
        Values.Low
    );

    public static readonly HarshBrakeSensitivityV2SettingsObjectResponseBodyLightDuty Normal = new(
        Values.Normal
    );

    public static readonly HarshBrakeSensitivityV2SettingsObjectResponseBodyLightDuty High = new(
        Values.High
    );

    public HarshBrakeSensitivityV2SettingsObjectResponseBodyLightDuty(string value)
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
    public static HarshBrakeSensitivityV2SettingsObjectResponseBodyLightDuty FromCustom(
        string value
    )
    {
        return new HarshBrakeSensitivityV2SettingsObjectResponseBodyLightDuty(value);
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
        HarshBrakeSensitivityV2SettingsObjectResponseBodyLightDuty value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        HarshBrakeSensitivityV2SettingsObjectResponseBodyLightDuty value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        HarshBrakeSensitivityV2SettingsObjectResponseBodyLightDuty value
    ) => value.Value;

    public static explicit operator HarshBrakeSensitivityV2SettingsObjectResponseBodyLightDuty(
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

        public const string VeryLow = "veryLow";

        public const string Low = "low";

        public const string Normal = "normal";

        public const string High = "high";
    }
}
