using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Hub location object
/// </summary>
[Serializable]
public record HubLocationObjectResponseBody : IJsonOnDeserialized
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
    /// The timestamp (in UTC) when the location was created
    /// </summary>
    [JsonPropertyName("createdAt")]
    public required DateTime CreatedAt { get; set; }

    /// <summary>
    /// The customer-provided identifier for the location
    /// </summary>
    [JsonPropertyName("customerLocationId")]
    public required string CustomerLocationId { get; set; }

    /// <summary>
    /// Instructions for the driver
    /// </summary>
    [JsonPropertyName("driverInstructions")]
    public required string DriverInstructions { get; set; }

    /// <summary>
    /// The ID of the hub this location belongs to
    /// </summary>
    [JsonPropertyName("hubId")]
    public required string HubId { get; set; }

    /// <summary>
    /// The Samsara-generated unique identifier (UUID) for the location
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// Indicates if the location is a depot
    /// </summary>
    [JsonPropertyName("isDepot")]
    public required bool IsDepot { get; set; }

    /// <summary>
    /// Latitude coordinate of the location
    /// </summary>
    [JsonPropertyName("latitude")]
    public required double Latitude { get; set; }

    /// <summary>
    /// Longitude coordinate of the location
    /// </summary>
    [JsonPropertyName("longitude")]
    public required double Longitude { get; set; }

    /// <summary>
    /// The name of the location
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Notes for the planner
    /// </summary>
    [JsonPropertyName("plannerNotes")]
    public required string PlannerNotes { get; set; }

    /// <summary>
    /// Estimated service time at this location in seconds
    /// </summary>
    [JsonPropertyName("serviceTimeSeconds")]
    public required int ServiceTimeSeconds { get; set; }

    /// <summary>
    /// An array of time windows during which service can be performed at this location
    /// </summary>
    [JsonPropertyName("serviceWindows")]
    public IEnumerable<ServiceWindowObjectResponseBody> ServiceWindows { get; set; } =
        new List<ServiceWindowObjectResponseBody>();

    /// <summary>
    /// An array of skills required for service at this location
    /// </summary>
    [JsonPropertyName("skillsRequired")]
    public IEnumerable<SkillObjectResponseBody> SkillsRequired { get; set; } =
        new List<SkillObjectResponseBody>();

    /// <summary>
    /// The timestamp (in UTC) when the location was last updated
    /// </summary>
    [JsonPropertyName("updatedAt")]
    public required DateTime UpdatedAt { get; set; }

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
