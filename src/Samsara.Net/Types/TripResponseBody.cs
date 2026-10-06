using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Trip
/// </summary>
[Serializable]
public record TripResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("asset")]
    public required TripAssetResponseBody Asset { get; set; }

    /// <summary>
    /// Trip completion status  Valid values: `inProgress`, `completed`
    /// </summary>
    [JsonPropertyName("completionStatus")]
    public required TripResponseBodyCompletionStatus CompletionStatus { get; set; }

    /// <summary>
    /// [RFC 3339] Time the trip was created in Samsara in UTC.
    /// </summary>
    [JsonPropertyName("createdAtTime")]
    public required string CreatedAtTime { get; set; }

    [JsonPropertyName("endLocation")]
    public LocationResponseResponseBody? EndLocation { get; set; }

    /// <summary>
    /// Final distance driven in meters, calculated from GPS data. Only populated once the trip has completed (`completionStatus: completed`); null while the trip is in progress. Later corrections (e.g. late-arriving GPS data) are not signaled by updatedAtTime.
    /// </summary>
    [JsonPropertyName("finalDistanceMeters")]
    public long? FinalDistanceMeters { get; set; }

    [JsonPropertyName("startLocation")]
    public required LocationResponseResponseBody StartLocation { get; set; }

    /// <summary>
    /// [RFC 3339] Time the trip ended in UTC.
    /// </summary>
    [JsonPropertyName("tripEndTime")]
    public string? TripEndTime { get; set; }

    /// <summary>
    /// The driver-assigned purpose of the trip. Only populated for completed trips when your organization is licensed for mileage reporting; null while the trip is in progress or when not licensed. `unassigned` means the driver has not classified the trip. Reflects the explicit Driver App classification, not automatic classification. When a driver changes the purpose after the trip completes, the trip is re-served through the `updatedAtTime` feed with the new value.  Valid values: `unknown`, `unassigned`, `personal`, `business`, `commute`
    /// </summary>
    [JsonPropertyName("tripPurpose")]
    public TripResponseBodyTripPurpose? TripPurpose { get; set; }

    /// <summary>
    /// [RFC 3339] Time the trip started in UTC.
    /// </summary>
    [JsonPropertyName("tripStartTime")]
    public required string TripStartTime { get; set; }

    /// <summary>
    /// [RFC 3339] Time the trip was updated in Samsara in UTC. Valid updates are when `endTime` populates, `completionStatus` changes values, or a driver changes the trip's `tripPurpose` after the trip has completed. To receive later purpose corrections, poll with `queryBy=updatedAtTime`; feed data trails real time by a few seconds.
    /// </summary>
    [JsonPropertyName("updatedAtTime")]
    public required string UpdatedAtTime { get; set; }

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
