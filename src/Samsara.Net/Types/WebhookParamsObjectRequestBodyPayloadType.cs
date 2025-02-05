using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<WebhookParamsObjectRequestBodyPayloadType>))]
public enum WebhookParamsObjectRequestBodyPayloadType
{
    [EnumMember(Value = "legacy")]
    Legacy,

    [EnumMember(Value = "enriched")]
    Enriched,
}
