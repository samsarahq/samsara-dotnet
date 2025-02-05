using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<UpdateEngineImmobilizerRelayStateRequestBodyRequestBodyId>))]
public enum UpdateEngineImmobilizerRelayStateRequestBodyRequestBodyId
{
    [EnumMember(Value = "relay1")]
    Relay1,

    [EnumMember(Value = "relay2")]
    Relay2,
}
