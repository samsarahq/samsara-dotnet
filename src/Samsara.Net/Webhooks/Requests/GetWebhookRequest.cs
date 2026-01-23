using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Webhooks;

[Serializable]
public record GetWebhookRequest
{
    /// <summary>
    /// ID of the webhook. This is the Samsara-specified ID.
    /// </summary>
    [JsonIgnore]
    public required string Id { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
