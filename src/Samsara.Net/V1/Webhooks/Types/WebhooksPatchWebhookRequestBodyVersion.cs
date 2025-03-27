using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.V1.Webhooks;

[JsonConverter(typeof(EnumSerializer<WebhooksPatchWebhookRequestBodyVersion>))]
public enum WebhooksPatchWebhookRequestBodyVersion
{
    [EnumMember(Value = "2018-01-01")]
    TwoThousandEighteen0101,

    [EnumMember(Value = "2021-06-09")]
    TwoThousandTwentyOne0609,

    [EnumMember(Value = "2022-09-13")]
    TwoThousandTwentyTwo0913,

    [EnumMember(Value = "2024-02-27")]
    TwoThousandTwentyFour0227,
}
