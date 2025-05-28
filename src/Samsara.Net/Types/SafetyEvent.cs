using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// A safety event.
/// </summary>
public record SafetyEvent
{
    [JsonPropertyName("behaviorLabels")]
    public IEnumerable<SafetyEventBehaviorLabel>? BehaviorLabels { get; set; }

    [JsonPropertyName("coachingState")]
    public SafetyEventCoachingState? CoachingState { get; set; }

    [JsonPropertyName("downloadForwardVideoUrl")]
    public string? DownloadForwardVideoUrl { get; set; }

    [JsonPropertyName("downloadInwardVideoUrl")]
    public string? DownloadInwardVideoUrl { get; set; }

    [JsonPropertyName("downloadTrackedInwardVideoUrl")]
    public string? DownloadTrackedInwardVideoUrl { get; set; }

    [JsonPropertyName("driver")]
    public DriverTinyResponse? Driver { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("location")]
    public Location? Location { get; set; }

    [JsonPropertyName("maxAccelerationGForce")]
    public double? MaxAccelerationGForce { get; set; }

    [JsonPropertyName("time")]
    public string? Time { get; set; }

    [JsonPropertyName("vehicle")]
    public VehicleTinyResponse? Vehicle { get; set; }

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
