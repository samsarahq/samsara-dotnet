using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record WebhookEvent
{
    /// <summary>
    /// Unique identifier for the event
    /// </summary>
    [JsonPropertyName("eventId")]
    public required string EventId { get; set; }

    /// <summary>
    /// Timestamp when the event was sent (Unix epoch in milliseconds)
    /// </summary>
    [JsonPropertyName("eventMs")]
    public required long EventMs { get; set; }

    /// <summary>
    /// Type of the event
    /// </summary>
    [JsonPropertyName("eventType")]
    public required string EventType { get; set; }

    [JsonPropertyName("event")]
    public required AlertEvent Event { get; set; }

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
