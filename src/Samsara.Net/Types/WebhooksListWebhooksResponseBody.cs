using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record WebhooksListWebhooksResponseBody
{
    /// <summary>
    /// This is a list of Webhooks.
    /// </summary>
    [JsonPropertyName("data")]
    public IEnumerable<WebhookResponseResponseBody> Data { get; set; } =
        new List<WebhookResponseResponseBody>();

    [JsonPropertyName("pagination")]
    public required GoaPaginationResponseResponseBody Pagination { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
