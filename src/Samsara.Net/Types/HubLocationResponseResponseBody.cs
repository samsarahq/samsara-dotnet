using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Route-planning hub location metadata row for a place.
/// </summary>
[Serializable]
public record HubLocationResponseResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Display name when available.
    /// </summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>
    /// External identifier for this hub row.
    /// </summary>
    [JsonPropertyName("externalId")]
    public string? ExternalId { get; set; }

    /// <summary>
    /// Hub (planner) UUID.
    /// </summary>
    [JsonPropertyName("hubId")]
    public required string HubId { get; set; }

    /// <summary>
    /// Stable hub location UUID.
    /// </summary>
    [JsonPropertyName("hubLocationId")]
    public required string HubLocationId { get; set; }

    /// <summary>
    /// Whether this hub location is a depot.
    /// </summary>
    [JsonPropertyName("isDepot")]
    public required bool IsDepot { get; set; }

    /// <summary>
    /// Whether order service time is ignored here.
    /// </summary>
    [JsonPropertyName("isIgnoreOrderServiceTimeEnabled")]
    public bool? IsIgnoreOrderServiceTimeEnabled { get; set; }

    /// <summary>
    /// Stop position preference: unknown, unspecified, any, first, or last.
    /// </summary>
    [JsonPropertyName("locationPositionType")]
    public required string LocationPositionType { get; set; }

    /// <summary>
    /// Route priority; higher is more important (0–5).
    /// </summary>
    [JsonPropertyName("locationPriority")]
    public int? LocationPriority { get; set; }

    [JsonPropertyName("orderServiceTime")]
    public HubLocationOrderServiceTimeResponseResponseBody? OrderServiceTime { get; set; }

    /// <summary>
    /// Planner-facing notes.
    /// </summary>
    [JsonPropertyName("plannerNotes")]
    public string? PlannerNotes { get; set; }

    /// <summary>
    /// Required planner skills.
    /// </summary>
    [JsonPropertyName("requiredSkills")]
    public IEnumerable<HubLocationRequiredSkillResponseResponseBody>? RequiredSkills { get; set; }

    [JsonPropertyName("serviceTime")]
    public HubLocationServiceTimeResponseResponseBody? ServiceTime { get; set; }

    /// <summary>
    /// Configured service windows.
    /// </summary>
    [JsonPropertyName("serviceWindows")]
    public IEnumerable<HubLocationServiceWindowResponseResponseBody>? ServiceWindows { get; set; }

    /// <summary>
    /// Default instructions for drivers.
    /// </summary>
    [JsonPropertyName("standardDriverInstructions")]
    public string? StandardDriverInstructions { get; set; }

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
