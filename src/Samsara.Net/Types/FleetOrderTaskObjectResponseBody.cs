using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// An action belonging to a canonical order.
/// </summary>
[Serializable]
public record FleetOrderTaskObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Creation timestamp in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("createdAtTime")]
    public required DateTime CreatedAtTime { get; set; }

    /// <summary>
    /// Task-specific customer metadata.
    /// </summary>
    [JsonPropertyName("customerProperties")]
    public IEnumerable<FleetOrderCustomerPropertyObjectResponseBody> CustomerProperties { get; set; } =
        new List<FleetOrderCustomerPropertyObjectResponseBody>();

    /// <summary>
    /// Dispatcher-visible note.
    /// </summary>
    [JsonPropertyName("dispatcherNotes")]
    public string? DispatcherNotes { get; set; }

    /// <summary>
    /// Driver-visible note.
    /// </summary>
    [JsonPropertyName("driverNotes")]
    public string? DriverNotes { get; set; }

    /// <summary>
    /// Hub UUID for the task.
    /// </summary>
    [JsonPropertyName("hubId")]
    public required string HubId { get; set; }

    /// <summary>
    /// Opaque task ID.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// Task position constraint.  Valid values: `unknown`, `none`, `first`, `last`
    /// </summary>
    [JsonPropertyName("positionConstraintType")]
    public required FleetOrderTaskObjectResponseBodyPositionConstraintType PositionConstraintType { get; set; }

    /// <summary>
    /// Task quantities.
    /// </summary>
    [JsonPropertyName("quantities")]
    public IEnumerable<FleetOrderQuantityObjectResponseBody> Quantities { get; set; } =
        new List<FleetOrderQuantityObjectResponseBody>();

    /// <summary>
    /// Route ID when this task is attached to a route.
    /// </summary>
    [JsonPropertyName("routeId")]
    public string? RouteId { get; set; }

    /// <summary>
    /// Expected service duration in seconds.
    /// </summary>
    [JsonPropertyName("serviceDurationSeconds")]
    public long? ServiceDurationSeconds { get; set; }

    [JsonPropertyName("serviceLocation")]
    public FleetOrderServiceLocationObjectResponseBody? ServiceLocation { get; set; }

    /// <summary>
    /// Task service windows.
    /// </summary>
    [JsonPropertyName("serviceWindows")]
    public IEnumerable<FleetOrderServiceWindowObjectResponseBody> ServiceWindows { get; set; } =
        new List<FleetOrderServiceWindowObjectResponseBody>();

    /// <summary>
    /// Task type.  Valid values: `unknown`, `delivery`, `pickup`, `pickupDelivery`
    /// </summary>
    [JsonPropertyName("taskType")]
    public required FleetOrderTaskObjectResponseBodyTaskType TaskType { get; set; }

    /// <summary>
    /// Last update timestamp in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("updatedAtTime")]
    public required DateTime UpdatedAtTime { get; set; }

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
