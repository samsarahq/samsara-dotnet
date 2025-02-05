using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<VehicleStatsSeatbeltDriverValue>))]
public enum VehicleStatsSeatbeltDriverValue
{
    [EnumMember(Value = "Buckled")]
    Buckled,

    [EnumMember(Value = "Unbuckled")]
    Unbuckled,
}
