using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<VehicleStatsSpreaderBlastStateValue>))]
public enum VehicleStatsSpreaderBlastStateValue
{
    [EnumMember(Value = "On")]
    On,

    [EnumMember(Value = "Off")]
    Off,
}
