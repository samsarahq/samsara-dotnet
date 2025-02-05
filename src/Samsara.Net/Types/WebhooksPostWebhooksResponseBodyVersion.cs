using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<WebhooksPostWebhooksResponseBodyVersion>))]
public enum WebhooksPostWebhooksResponseBodyVersion
{
    [EnumMember(Value = "2018-01-01")]
    TwoThousandEighteen0101,

    [EnumMember(Value = "2021-06-09")]
    TwoThousandTwentyOne0609,
}
