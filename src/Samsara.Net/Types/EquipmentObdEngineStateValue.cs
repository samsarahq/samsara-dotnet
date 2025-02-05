using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<EquipmentObdEngineStateValue>))]
public enum EquipmentObdEngineStateValue
{
    [EnumMember(Value = "Off")]
    Off,

    [EnumMember(Value = "On")]
    On,

    [EnumMember(Value = "Idle")]
    Idle,
}
