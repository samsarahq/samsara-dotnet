using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<HarshTurnSensitivityV2SettingsObjectResponseBodyPassenger>)
)]
[Serializable]
public readonly record struct HarshTurnSensitivityV2SettingsObjectResponseBodyPassenger
    : IStringEnum
{
    public static readonly HarshTurnSensitivityV2SettingsObjectResponseBodyPassenger Unknown = new(
        Values.Unknown
    );

    public static readonly HarshTurnSensitivityV2SettingsObjectResponseBodyPassenger Invalid = new(
        Values.Invalid
    );

    public static readonly HarshTurnSensitivityV2SettingsObjectResponseBodyPassenger Off = new(
        Values.Off
    );

    public static readonly HarshTurnSensitivityV2SettingsObjectResponseBodyPassenger VeryLow = new(
        Values.VeryLow
    );

    public static readonly HarshTurnSensitivityV2SettingsObjectResponseBodyPassenger Low = new(
        Values.Low
    );

    public static readonly HarshTurnSensitivityV2SettingsObjectResponseBodyPassenger Normal = new(
        Values.Normal
    );

    public static readonly HarshTurnSensitivityV2SettingsObjectResponseBodyPassenger High = new(
        Values.High
    );

    public HarshTurnSensitivityV2SettingsObjectResponseBodyPassenger(string value)
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
    public static HarshTurnSensitivityV2SettingsObjectResponseBodyPassenger FromCustom(string value)
    {
        return new HarshTurnSensitivityV2SettingsObjectResponseBodyPassenger(value);
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
        HarshTurnSensitivityV2SettingsObjectResponseBodyPassenger value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        HarshTurnSensitivityV2SettingsObjectResponseBodyPassenger value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        HarshTurnSensitivityV2SettingsObjectResponseBodyPassenger value
    ) => value.Value;

    public static explicit operator HarshTurnSensitivityV2SettingsObjectResponseBodyPassenger(
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
