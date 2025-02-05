using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<V1SensorsHistorySeriesField>))]
public enum V1SensorsHistorySeriesField
{
    [EnumMember(Value = "ambientTemperature")]
    AmbientTemperature,

    [EnumMember(Value = "cargoPercent")]
    CargoPercent,

    [EnumMember(Value = "currentLoop1Raw")]
    CurrentLoop1Raw,

    [EnumMember(Value = "currentLoop1Mapped")]
    CurrentLoop1Mapped,

    [EnumMember(Value = "currentLoop2Raw")]
    CurrentLoop2Raw,

    [EnumMember(Value = "currentLoop2Mapped")]
    CurrentLoop2Mapped,

    [EnumMember(Value = "doorClosed")]
    DoorClosed,

    [EnumMember(Value = "humidity")]
    Humidity,

    [EnumMember(Value = "pmPowerTotal")]
    PmPowerTotal,

    [EnumMember(Value = "pmPhase1Power")]
    PmPhase1Power,

    [EnumMember(Value = "pmPhase2Power")]
    PmPhase2Power,

    [EnumMember(Value = "pmPhase3Power")]
    PmPhase3Power,

    [EnumMember(Value = "pmPhase1PowerFactor")]
    PmPhase1PowerFactor,

    [EnumMember(Value = "pmPhase2PowerFactor")]
    PmPhase2PowerFactor,

    [EnumMember(Value = "pmPhase3PowerFactor")]
    PmPhase3PowerFactor,

    [EnumMember(Value = "probeTemperature")]
    ProbeTemperature,
}
