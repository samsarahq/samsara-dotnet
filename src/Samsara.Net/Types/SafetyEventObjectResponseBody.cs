using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// The safety event that was updated.
/// </summary>
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
