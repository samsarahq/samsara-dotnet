using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// An order task to create or update. Required fields are enforced by the transport; value constraints are validated per batch item.
/// </summary>
[Serializable]
public record FleetOrderBatchTaskUpsertInputRequestBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Task-specific customer metadata.
    /// </summary>
    [JsonPropertyName("customerProperties")]
    public IEnumerable<FleetOrderBatchCustomerPropertyInputRequestBody>? CustomerProperties { get; set; }

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
    /// Hub UUID for this task.
    /// </summary>
    [JsonPropertyName("hubId")]
    public required string HubId { get; set; }

    /// <summary>
    /// Existing task ID. Omit to create a task.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Task position constraint. Must be none, first, or last.
    /// </summary>
    [JsonPropertyName("positionConstraintType")]
    public string? PositionConstraintType { get; set; }

    /// <summary>
    /// Task quantities.
    /// </summary>
    [JsonPropertyName("quantities")]
    public IEnumerable<FleetOrderBatchQuantityInputRequestBody>? Quantities { get; set; }

    /// <summary>
    /// Expected non-negative service duration in seconds.
    /// </summary>
    [JsonPropertyName("serviceDurationSeconds")]
    public long? ServiceDurationSeconds { get; set; }

    [JsonPropertyName("serviceLocation")]
    public FleetOrderBatchServiceLocationInputRequestBody? ServiceLocation { get; set; }

    /// <summary>
    /// Existing service window UUIDs to retire.
    /// </summary>
    [JsonPropertyName("serviceWindowIdsToRemove")]
    public IEnumerable<string>? ServiceWindowIdsToRemove { get; set; }

    /// <summary>
    /// Service windows to create or update.
    /// </summary>
    [JsonPropertyName("serviceWindows")]
    public IEnumerable<FleetOrderBatchServiceWindowUpsertInputRequestBody>? ServiceWindows { get; set; }

    /// <summary>
    /// Task type. Must be delivery, pickup, or pickupDelivery.
    /// </summary>
    [JsonPropertyName("taskType")]
    public required string TaskType { get; set; }

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
