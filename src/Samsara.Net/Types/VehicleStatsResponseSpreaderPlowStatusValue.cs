using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<VehicleStatsResponseSpreaderPlowStatusValue>))]
public enum VehicleStatsResponseSpreaderPlowStatusValue
{
    [EnumMember(Value = "Up")]
    Up,

    [EnumMember(Value = "Down")]
    Down,
}
