using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Input object for creating hub locations
/// </summary>
[Serializable]
public record HubLocationInputObjectRequestBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The physical address of the location
    /// </summary>
    [JsonPropertyName("address")]
    public required string Address { get; set; }

    /// <summary>
    /// The customer-provided identifier for the location
    /// </summary>
    [JsonPropertyName("customerLocationId")]
    public required string CustomerLocationId { get; set; }

    /// <summary>
    /// Instructions for the driver
    /// </summary>
    [JsonPropertyName("driverInstructions")]
    public string? DriverInstructions { get; set; }

    /// <summary>
    /// The ID of the hub this location belongs to
    /// </summary>
    [JsonPropertyName("hubId")]
    public required string HubId { get; set; }

    /// <summary>
    /// Indicates if the location is a depot
    /// </summary>
    [JsonPropertyName("isDepot")]
    public required bool IsDepot { get; set; }

    /// <summary>
    /// Latitude coordinate of the location. If not provided and address is provided, the address will be geocoded to obtain coordinates.
    /// </summary>
    [JsonPropertyName("latitude")]
    public double? Latitude { get; set; }

    /// <summary>
    /// Longitude coordinate of the location. If not provided and address is provided, the address will be geocoded to obtain coordinates.
    /// </summary>
    [JsonPropertyName("longitude")]
    public double? Longitude { get; set; }

    /// <summary>
    /// The name of the location
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Notes for the planner
    /// </summary>
    [JsonPropertyName("plannerNotes")]
    public string? PlannerNotes { get; set; }

    /// <summary>
    /// Estimated service time at this location in seconds
    /// </summary>
    [JsonPropertyName("serviceTimeSeconds")]
    public int? ServiceTimeSeconds { get; set; }

    /// <summary>
    /// An array of time windows during which service can be performed at this location
    /// </summary>
    [JsonPropertyName("serviceWindows")]
    public IEnumerable<HubLocationServiceWindowInputRequestBody>? ServiceWindows { get; set; }

    /// <summary>
    /// An array of skill IDs required for service at this location
    /// </summary>
    [JsonPropertyName("skillsRequired")]
    public IEnumerable<string>? SkillsRequired { get; set; }

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
