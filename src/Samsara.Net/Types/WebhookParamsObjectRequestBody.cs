using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record WebhookParamsObjectRequestBody
{
    /// <summary>
    /// This determines the alert webhook payload type to use. Learn more: https://developers.samsara.com/docs/webhook-reference.  Valid values: `legacy`, `enriched`
    /// </summary>
    [JsonPropertyName("payloadType")]
    public WebhookParamsObjectRequestBodyPayloadType? PayloadType { get; set; }

    /// <summary>
    /// The webhook IDs.
    /// </summary>
    [JsonPropertyName("webhookIds")]
    public IEnumerable<string> WebhookIds { get; set; } = new List<string>();

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
