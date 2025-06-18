using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Equipment.Stats;

[JsonConverter(typeof(EnumSerializer<StatsListRequestTypesItem>))]
public enum StatsListRequestTypesItem
{
    [EnumMember(Value = "gatewayEngineStates")]
    GatewayEngineStates,

    [EnumMember(Value = "obdEngineStates")]
    ObdEngineStates,

    [EnumMember(Value = "fuelPercents")]
    FuelPercents,

    [EnumMember(Value = "engineRpm")]
    EngineRpm,

    [EnumMember(Value = "gatewayEngineSeconds")]
    GatewayEngineSeconds,

    [EnumMember(Value = "obdEngineSeconds")]
    ObdEngineSeconds,

    [EnumMember(Value = "gatewayJ1939EngineSeconds")]
    GatewayJ1939EngineSeconds,

    [EnumMember(Value = "gpsOdometerMeters")]
    GpsOdometerMeters,

    [EnumMember(Value = "gps")]
    Gps,

    [EnumMember(Value = "engineTotalIdleTimeMinutes")]
    EngineTotalIdleTimeMinutes,
}
