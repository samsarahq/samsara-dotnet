using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Route-planning metadata row for a place and hub.
/// </summary>
[Serializable]
public record PlaceRoutingInputRequestBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Default instructions for drivers at this stop.
    /// </summary>
    [JsonPropertyName("driverInstructions")]
    public string? DriverInstructions { get; set; }

    /// <summary>
    /// Planner hub UUID for this row.
    /// </summary>
    [JsonPropertyName("hubId")]
    public required string HubId { get; set; }

    /// <summary>
    /// Hub-facing notes for this routing row.
    /// </summary>
    [JsonPropertyName("hubNotes")]
    public string? HubNotes { get; set; }

    /// <summary>
    /// Whether this routing row is a depot.
    /// </summary>
    [JsonPropertyName("isDepot")]
    public bool? IsDepot { get; set; }

    [JsonPropertyName("orderServiceTime")]
    public PlaceRoutingOrderServiceTimeInputRequestBody? OrderServiceTime { get; set; }

    /// <summary>
    /// Stop position preference: unknown, unspecified, any, first, or last.
    /// </summary>
    [JsonPropertyName("position")]
    public string? Position { get; set; }

    /// <summary>
    /// Route priority from 1 (lowest) to 5 (highest).
    /// </summary>
    [JsonPropertyName("priority")]
    public int? Priority { get; set; }

    /// <summary>
    /// Required planner skills for this routing row.
    /// </summary>
    [JsonPropertyName("requiredSkills")]
    public IEnumerable<PlaceRoutingRequiredSkillInputRequestBody>? RequiredSkills { get; set; }

    /// <summary>
    /// Customer-defined external identifier within the hub.
    /// </summary>
    [JsonPropertyName("routingExternalId")]
    public string? RoutingExternalId { get; set; }

    [JsonPropertyName("serviceTime")]
    public PlaceRoutingServiceTimeInputRequestBody? ServiceTime { get; set; }

    /// <summary>
    /// Recurring local-time service windows for this routing row.
    /// </summary>
    [JsonPropertyName("serviceWindows")]
    public IEnumerable<PlaceRoutingServiceWindowInputRequestBody>? ServiceWindows { get; set; }

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
