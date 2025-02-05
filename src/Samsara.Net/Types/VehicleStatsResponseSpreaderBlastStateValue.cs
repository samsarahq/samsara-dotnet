using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<VehicleStatsResponseSpreaderBlastStateValue>))]
public enum VehicleStatsResponseSpreaderBlastStateValue
{
    [EnumMember(Value = "On")]
    On,

    [EnumMember(Value = "Off")]
    Off,
}
