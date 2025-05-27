using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// The webhook configuration for an Action.
/// </summary>
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

    /// <summary>
    /// Additional properties received from the response, if any.
    /// </summary>
    /// <remarks>
    /// [EXPERIMENTAL] This API is experimental and may change in future releases.
    /// </remarks>
    [JsonExtensionData]
    public IDictionary<string, JsonElement> AdditionalProperties { get; internal set; } =
        new Dictionary<string, JsonElement>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
