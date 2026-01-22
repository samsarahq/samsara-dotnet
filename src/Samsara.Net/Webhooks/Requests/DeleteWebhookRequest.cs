using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Webhooks;

[Serializable]
public record DeleteWebhookRequest
{
    /// <summary>
    /// Unique identifier for the webhook to delete.
    /// </summary>
    [JsonIgnore]
    public required string Id { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
