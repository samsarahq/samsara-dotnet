using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<VehicleStatsResponseSeatbeltDriverValue>))]
public enum VehicleStatsResponseSeatbeltDriverValue
{
    [EnumMember(Value = "Buckled")]
    Buckled,

    [EnumMember(Value = "Unbuckled")]
    Unbuckled,
}
