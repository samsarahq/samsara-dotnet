using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<V1SensorsHistorySeriesField>))]
[Serializable]
public readonly record struct V1SensorsHistorySeriesField : IStringEnum
{
    public static readonly V1SensorsHistorySeriesField AmbientTemperature = new(
        Values.AmbientTemperature
    );

    public static readonly V1SensorsHistorySeriesField CargoPercent = new(Values.CargoPercent);

    public static readonly V1SensorsHistorySeriesField CurrentLoop1Raw = new(
        Values.CurrentLoop1Raw
    );

    public static readonly V1SensorsHistorySeriesField CurrentLoop1Mapped = new(
        Values.CurrentLoop1Mapped
    );

    public static readonly V1SensorsHistorySeriesField CurrentLoop2Raw = new(
        Values.CurrentLoop2Raw
    );

    public static readonly V1SensorsHistorySeriesField CurrentLoop2Mapped = new(
        Values.CurrentLoop2Mapped
    );

    public static readonly V1SensorsHistorySeriesField DoorClosed = new(Values.DoorClosed);

    public static readonly V1SensorsHistorySeriesField Humidity = new(Values.Humidity);

    public static readonly V1SensorsHistorySeriesField PmPowerTotal = new(Values.PmPowerTotal);

    public static readonly V1SensorsHistorySeriesField PmPhase1Power = new(Values.PmPhase1Power);

    public static readonly V1SensorsHistorySeriesField PmPhase2Power = new(Values.PmPhase2Power);

    public static readonly V1SensorsHistorySeriesField PmPhase3Power = new(Values.PmPhase3Power);

    public static readonly V1SensorsHistorySeriesField PmPhase1PowerFactor = new(
        Values.PmPhase1PowerFactor
    );

    public static readonly V1SensorsHistorySeriesField PmPhase2PowerFactor = new(
        Values.PmPhase2PowerFactor
    );

    public static readonly V1SensorsHistorySeriesField PmPhase3PowerFactor = new(
        Values.PmPhase3PowerFactor
    );

    public static readonly V1SensorsHistorySeriesField ProbeTemperature = new(
        Values.ProbeTemperature
    );

    public V1SensorsHistorySeriesField(string value)
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
    public static V1SensorsHistorySeriesField FromCustom(string value)
    {
        return new V1SensorsHistorySeriesField(value);
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

    public static bool operator ==(V1SensorsHistorySeriesField value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(V1SensorsHistorySeriesField value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(V1SensorsHistorySeriesField value) => value.Value;

    public static explicit operator V1SensorsHistorySeriesField(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string AmbientTemperature = "ambientTemperature";

        public const string CargoPercent = "cargoPercent";

        public const string CurrentLoop1Raw = "currentLoop1Raw";

        public const string CurrentLoop1Mapped = "currentLoop1Mapped";

        public const string CurrentLoop2Raw = "currentLoop2Raw";

        public const string CurrentLoop2Mapped = "currentLoop2Mapped";

        public const string DoorClosed = "doorClosed";

        public const string Humidity = "humidity";

        public const string PmPowerTotal = "pmPowerTotal";

        public const string PmPhase1Power = "pmPhase1Power";

        public const string PmPhase2Power = "pmPhase2Power";

        public const string PmPhase3Power = "pmPhase3Power";

        public const string PmPhase1PowerFactor = "pmPhase1PowerFactor";

        public const string PmPhase2PowerFactor = "pmPhase2PowerFactor";

        public const string PmPhase3PowerFactor = "pmPhase3PowerFactor";

        public const string ProbeTemperature = "probeTemperature";
    }
}
