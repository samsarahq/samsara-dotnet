using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<HarshBrakeSensitivityV2SettingsObjectResponseBodyHeavyDuty>)
)]
[Serializable]
public readonly record struct HarshBrakeSensitivityV2SettingsObjectResponseBodyHeavyDuty
    : IStringEnum
{
    public static readonly HarshBrakeSensitivityV2SettingsObjectResponseBodyHeavyDuty Unknown = new(
        Values.Unknown
    );

    public static readonly HarshBrakeSensitivityV2SettingsObjectResponseBodyHeavyDuty Invalid = new(
        Values.Invalid
    );

    public static readonly HarshBrakeSensitivityV2SettingsObjectResponseBodyHeavyDuty Off = new(
        Values.Off
    );

    public static readonly HarshBrakeSensitivityV2SettingsObjectResponseBodyHeavyDuty VeryLow = new(
        Values.VeryLow
    );

    public static readonly HarshBrakeSensitivityV2SettingsObjectResponseBodyHeavyDuty Low = new(
        Values.Low
    );

    public static readonly HarshBrakeSensitivityV2SettingsObjectResponseBodyHeavyDuty Normal = new(
        Values.Normal
    );

    public static readonly HarshBrakeSensitivityV2SettingsObjectResponseBodyHeavyDuty High = new(
        Values.High
    );

    public HarshBrakeSensitivityV2SettingsObjectResponseBodyHeavyDuty(string value)
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
    public static HarshBrakeSensitivityV2SettingsObjectResponseBodyHeavyDuty FromCustom(
        string value
    )
    {
        return new HarshBrakeSensitivityV2SettingsObjectResponseBodyHeavyDuty(value);
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
        HarshBrakeSensitivityV2SettingsObjectResponseBodyHeavyDuty value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        HarshBrakeSensitivityV2SettingsObjectResponseBodyHeavyDuty value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        HarshBrakeSensitivityV2SettingsObjectResponseBodyHeavyDuty value
    ) => value.Value;

    public static explicit operator HarshBrakeSensitivityV2SettingsObjectResponseBodyHeavyDuty(
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
