using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// GroundIntelligenceIssue object
/// </summary>
[Serializable]
public record EntityListIssuesTypeResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Time when this issue record was created.
    /// </summary>
    [JsonPropertyName("createdAtTime")]
    public string? CreatedAtTime { get; set; }

    /// <summary>
    /// URL to view this issue in the Samsara dashboard.
    /// </summary>
    [JsonPropertyName("dashboardUrl")]
    public string? DashboardUrl { get; set; }

    /// <summary>
    /// Time when this issue was first observed.
    /// </summary>
    [JsonPropertyName("firstSeenTime")]
    public string? FirstSeenTime { get; set; }

    /// <summary>
    /// Unique identifier for the issue.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Time when this issue was most recently observed.
    /// </summary>
    [JsonPropertyName("lastSeenTime")]
    public string? LastSeenTime { get; set; }

    [JsonPropertyName("location")]
    public ListIssuesEntityGroundIntelligenceIssueGroundIntelligenceIssueLocationTypeResponseBody? Location { get; set; }

    /// <summary>
    /// Number of evidence records aggregated into this issue.
    /// </summary>
    [JsonPropertyName("observationCount")]
    public long? ObservationCount { get; set; }

    [JsonPropertyName("roadSegment")]
    public ListIssuesEntityGroundIntelligenceIssueGroundIntelligenceIssueRoadSegmentTypeResponseBody? RoadSegment { get; set; }

    /// <summary>
    /// Customer-facing severity level for this issue.
    /// </summary>
    [JsonPropertyName("severity")]
    public string? Severity { get; set; }

    /// <summary>
    /// Current customer-facing review status of this issue.
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>
    /// Customer-facing type for this issue.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// Time when this issue record was most recently updated.
    /// </summary>
    [JsonPropertyName("updatedAtTime")]
    public string? UpdatedAtTime { get; set; }

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
