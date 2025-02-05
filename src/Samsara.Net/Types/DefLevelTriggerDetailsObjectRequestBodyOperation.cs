using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<DefLevelTriggerDetailsObjectRequestBodyOperation>))]
public enum DefLevelTriggerDetailsObjectRequestBodyOperation
{
    [EnumMember(Value = "GREATER")]
    Greater,

    [EnumMember(Value = "LESS")]
    Less,
}
