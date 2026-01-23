using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Harsh event details for a vehicle
/// </summary>
[Serializable]
public record V1VehicleHarshEventResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

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

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
