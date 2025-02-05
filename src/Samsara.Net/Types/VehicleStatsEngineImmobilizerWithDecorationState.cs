using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<VehicleStatsEngineImmobilizerWithDecorationState>))]
public enum VehicleStatsEngineImmobilizerWithDecorationState
{
    [EnumMember(Value = "ignition_disabled")]
    IgnitionDisabled,

    [EnumMember(Value = "ignition_enabled")]
    IgnitionEnabled,
}
