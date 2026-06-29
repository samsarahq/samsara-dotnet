using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Route-planning metadata row for a place and hub.
/// </summary>
[Serializable]
public record RoutingResponseResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Default instructions for drivers.
    /// </summary>
    [JsonPropertyName("driverInstructions")]
    public string? DriverInstructions { get; set; }

    /// <summary>
    /// Hub (planner) UUID.
    /// </summary>
    [JsonPropertyName("hubId")]
    public required string HubId { get; set; }

    /// <summary>
    /// Hub-facing notes.
    /// </summary>
    [JsonPropertyName("hubNotes")]
    public string? HubNotes { get; set; }

    /// <summary>
    /// Whether this routing row is a depot.
    /// </summary>
    [JsonPropertyName("isDepot")]
    public required bool IsDepot { get; set; }

    [JsonPropertyName("orderServiceTime")]
    public RoutingOrderServiceTimeResponseResponseBody? OrderServiceTime { get; set; }

    /// <summary>
    /// Stop position preference: unknown, unspecified, any, first, or last.
    /// </summary>
    [JsonPropertyName("position")]
    public required string Position { get; set; }

    /// <summary>
    /// Route priority from 1 (lowest) to 5 (highest).
    /// </summary>
    [JsonPropertyName("priority")]
    public int? Priority { get; set; }

    /// <summary>
    /// Required planner skills.
    /// </summary>
    [JsonPropertyName("requiredSkills")]
    public IEnumerable<RoutingRequiredSkillResponseResponseBody>? RequiredSkills { get; set; }

    /// <summary>
    /// Customer-defined external identifier within the hub.
    /// </summary>
    [JsonPropertyName("routingExternalId")]
    public string? RoutingExternalId { get; set; }

    [JsonPropertyName("serviceTime")]
    public RoutingServiceTimeResponseResponseBody? ServiceTime { get; set; }

    /// <summary>
    /// Configured service windows.
    /// </summary>
    [JsonPropertyName("serviceWindows")]
    public IEnumerable<RoutingServiceWindowResponseResponseBody>? ServiceWindows { get; set; }

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
