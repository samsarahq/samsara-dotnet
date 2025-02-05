using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record SafetyEventObjectResponseBody
{
    /// <summary>
    /// Behavior labels for a safety event.
    /// </summary>
    [JsonPropertyName("behaviorLabels")]
    public IEnumerable<SafetyEventBehaviorLabelsResponseBody>? BehaviorLabels { get; set; }

    [JsonPropertyName("driver")]
    public SafetyEventDriverObjectResponseBody? Driver { get; set; }

    /// <summary>
    /// The unique Samsara ID of the safety event.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// The time the safety event occurred in RFC 3339 milliseconds format.
    /// </summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }

    [JsonPropertyName("vehicle")]
    public SafetyEventVehicleObjectResponseBody? Vehicle { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
