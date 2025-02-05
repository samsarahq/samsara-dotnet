using System.Text.Json.Serialization;
using Samsara.Net;
using Samsara.Net.Core;

namespace Samsara.Net.V1.Webhooks;

public record WebhooksPatchWebhookRequestBody
{
    /// <summary>
    /// The list of custom headers that users can include with their request
    /// </summary>
    [JsonPropertyName("customHeaders")]
    public IEnumerable<CustomHeadersObjectRequestBody>? CustomHeaders { get; set; }

    /// <summary>
    /// The  name of the webhook. This will appear in both Samsara’s cloud dashboard and the API. It can be set or updated through the Samsara Dashboard or through the API at any time.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The url of the webhook. This will appear in both Samsara’s cloud dashboard and the API. It can be set or updated through the Samsara Dashboard or through the API at any time.
    /// </summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>
    /// The version of the webhook.  Valid values: `2018-01-01`, `2021-06-09`, `2022-09-13`, `2024-02-27`
    /// </summary>
    [JsonPropertyName("version")]
    public WebhooksPatchWebhookRequestBodyVersion? Version { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
