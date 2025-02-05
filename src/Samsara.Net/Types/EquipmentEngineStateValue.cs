using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<EquipmentEngineStateValue>))]
public enum EquipmentEngineStateValue
{
    [EnumMember(Value = "Off")]
    Off,

    [EnumMember(Value = "On")]
    On,
}
