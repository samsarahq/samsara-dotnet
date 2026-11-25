using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// ListIssuesEntityGroundIntelligenceIssueGroundIntelligenceIssueRoadSegment object
/// </summary>
[Serializable]
public record ListIssuesEntityGroundIntelligenceIssueGroundIntelligenceIssueRoadSegmentTypeResponseBody
    : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Read-only Base Maps Overture road-class slug for the matched road segment (for example, motorway or residential), when available. Sourced from basemapsservice; not writable via update.
    /// </summary>
    [JsonPropertyName("roadClass")]
    public string? RoadClass { get; set; }

    /// <summary>
    /// Road name associated with this issue, when available.
    /// </summary>
    [JsonPropertyName("roadName")]
    public string? RoadName { get; set; }

    /// <summary>
    /// Read-only Base Maps Overture surface slug covering the issue's snapped position (for example, paved or gravel), when available. Sourced from basemapsservice; not writable via update.
    /// </summary>
    [JsonPropertyName("roadSurface")]
    public string? RoadSurface { get; set; }

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
