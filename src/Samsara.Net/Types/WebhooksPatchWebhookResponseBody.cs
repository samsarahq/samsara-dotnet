using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record WebhooksPatchWebhookResponseBody
{
    /// <summary>
    /// The list of custom headers that users can include with their request
    /// </summary>
    [JsonPropertyName("customHeaders")]
    public IEnumerable<CustomHeadersObjectResponseBody>? CustomHeaders { get; set; }

    /// <summary>
    /// The list of event types associated with a particular webhook.
    /// </summary>
    [JsonPropertyName("eventTypes")]
    public IEnumerable<WebhooksPatchWebhookResponseBodyEventTypesItem>? EventTypes { get; set; }

    /// <summary>
    /// The ID of the webhook. This will appear in both Samsara’s cloud dashboard and the API. This is the id of the webhook. This is system generated.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// The name of the webhook. This will appear in both Samsara’s cloud dashboard and the API. It can be set or updated through the Samsara Dashboard or through the API at any time.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// The secret key of the webhook. This will appear in both Samsara’s cloud dashboard and the API.
    /// </summary>
    [JsonPropertyName("secretKey")]
    public required string SecretKey { get; set; }

    /// <summary>
    /// The url of the webhook. This will appear in both Samsara’s cloud dashboard and the API. It can be set or updated through the Samsara Dashboard or through the API at any time.
    /// </summary>
    [JsonPropertyName("url")]
    public required string Url { get; set; }

    /// <summary>
    /// The version of the webhook.  Valid values: `2018-01-01`, `2021-06-09`
    /// </summary>
    [JsonPropertyName("version")]
    public required WebhooksPatchWebhookResponseBodyVersion Version { get; set; }

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
