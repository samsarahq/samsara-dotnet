using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<VehicleStatsResponseSpreaderOnStateValue>))]
public enum VehicleStatsResponseSpreaderOnStateValue
{
    [EnumMember(Value = "On")]
    On,

    [EnumMember(Value = "Off")]
    Off,
}
