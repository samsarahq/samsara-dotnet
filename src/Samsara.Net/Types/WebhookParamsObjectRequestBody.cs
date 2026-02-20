using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// The webhook configuration for an Action.
/// </summary>
[Serializable]
public record WebhookParamsObjectRequestBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// This determines the alert webhook payload type to use. Learn more: /docs/webhook-reference.  Valid values: `legacy`, `enriched`
    /// </summary>
    [JsonPropertyName("payloadType")]
    public WebhookParamsObjectRequestBodyPayloadType? PayloadType { get; set; }

    /// <summary>
    /// The webhook IDs.
    /// </summary>
    [JsonPropertyName("webhookIds")]
    public IEnumerable<string> WebhookIds { get; set; } = new List<string>();

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
