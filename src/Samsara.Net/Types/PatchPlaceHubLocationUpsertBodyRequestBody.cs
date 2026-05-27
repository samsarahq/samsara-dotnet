using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Hub location upsert entry for PATCH /places.
/// </summary>
[Serializable]
public record PatchPlaceHubLocationUpsertBodyRequestBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Optional label; stored as planner-facing notes for this hub row.
    /// </summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>
    /// External identifier for this hub row.
    /// </summary>
    [JsonPropertyName("externalId")]
    public string? ExternalId { get; set; }

    /// <summary>
    /// Planner hub UUID for this row.
    /// </summary>
    [JsonPropertyName("hubId")]
    public required string HubId { get; set; }

    /// <summary>
    /// Existing hub location UUID; omit to create a new row.
    /// </summary>
    [JsonPropertyName("hubLocationId")]
    public string? HubLocationId { get; set; }

    /// <summary>
    /// Whether this hub location is a depot.
    /// </summary>
    [JsonPropertyName("isDepot")]
    public bool? IsDepot { get; set; }

    /// <summary>
    /// Whether order service time is ignored at this location.
    /// </summary>
    [JsonPropertyName("isIgnoreOrderServiceTimeEnabled")]
    public bool? IsIgnoreOrderServiceTimeEnabled { get; set; }

    /// <summary>
    /// Stop position preference: unspecified, any, first, or last.
    /// </summary>
    [JsonPropertyName("locationPositionType")]
    public string? LocationPositionType { get; set; }

    /// <summary>
    /// Route priority from 1 (lowest) to 5 (highest).
    /// </summary>
    [JsonPropertyName("locationPriority")]
    public int? LocationPriority { get; set; }

    [JsonPropertyName("orderServiceTime")]
    public PlaceHubLocationOrderServiceTimeInputRequestBody? OrderServiceTime { get; set; }

    /// <summary>
    /// Required planner skills for this hub location.
    /// </summary>
    [JsonPropertyName("requiredSkills")]
    public IEnumerable<PlaceHubLocationRequiredSkillInputRequestBody>? RequiredSkills { get; set; }

    [JsonPropertyName("serviceTime")]
    public PlaceHubLocationServiceTimeInputRequestBody? ServiceTime { get; set; }

    /// <summary>
    /// Recurring local-time service windows for this hub location.
    /// </summary>
    [JsonPropertyName("serviceWindows")]
    public IEnumerable<PlaceHubLocationServiceWindowInputRequestBody>? ServiceWindows { get; set; }

    /// <summary>
    /// Default instructions for drivers at this hub location.
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
