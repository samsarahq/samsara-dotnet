using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Harsh event details for a vehicle
/// </summary>
public record V1VehicleHarshEventResponse
{
    /// <summary>
    /// URL for downloading the forward facing video
    /// </summary>
    [JsonPropertyName("downloadForwardVideoUrl")]
    public string? DownloadForwardVideoUrl { get; set; }

    /// <summary>
    /// URL for downloading the inward facing video
    /// </summary>
    [JsonPropertyName("downloadInwardVideoUrl")]
    public string? DownloadInwardVideoUrl { get; set; }

    /// <summary>
    /// URL for downloading the tracked inward facing video
    /// </summary>
    [JsonPropertyName("downloadTrackedInwardVideoUrl")]
    public string? DownloadTrackedInwardVideoUrl { get; set; }

    /// <summary>
    /// Type of the harsh event. One of: [Crash, Harsh Acceleration, Harsh Braking, Harsh Turn, ROP Engine, ROP Brake, YC Engine, YC Brake, Harsh Event]
    /// </summary>
    [JsonPropertyName("harshEventType")]
    public required string HarshEventType { get; set; }

    /// <summary>
    /// URL of the associated incident report page
    /// </summary>
    [JsonPropertyName("incidentReportUrl")]
    public required string IncidentReportUrl { get; set; }

    /// <summary>
    /// Whether the driver was deemed distracted during this harsh event
    /// </summary>
    [JsonPropertyName("isDistracted")]
    public bool? IsDistracted { get; set; }

    [JsonPropertyName("location")]
    public V1VehicleHarshEventResponseLocation? Location { get; set; }

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
