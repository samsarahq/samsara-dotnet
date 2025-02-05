using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<VehicleStatsSpreaderPlowStatusValue>))]
public enum VehicleStatsSpreaderPlowStatusValue
{
    [EnumMember(Value = "Up")]
    Up,

    [EnumMember(Value = "Down")]
    Down,
}
