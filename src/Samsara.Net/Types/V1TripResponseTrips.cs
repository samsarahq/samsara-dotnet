using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[Serializable]
public record V1TripResponseTrips : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// List of associated asset IDs
    /// </summary>
    [JsonPropertyName("assetIds")]
    public IEnumerable<long>? AssetIds { get; set; }

    /// <summary>
    /// List of codriver IDs
    /// </summary>
    [JsonPropertyName("codriverIds")]
    public IEnumerable<long>? CodriverIds { get; set; }

    /// <summary>
    /// Length of the trip in meters. This value is calculated from the GPS data collected by the Samsara Vehicle Gateway.
    /// </summary>
    [JsonPropertyName("distanceMeters")]
    public long? DistanceMeters { get; set; }

    /// <summary>
    /// ID of the driver.
    /// </summary>
    [JsonPropertyName("driverId")]
    public long? DriverId { get; set; }

    [JsonPropertyName("endAddress")]
    public V1TripResponseEndAddress? EndAddress { get; set; }

    [JsonPropertyName("endCoordinates")]
    public V1TripResponseEndCoordinates? EndCoordinates { get; set; }

    /// <summary>
    /// Geocoded street address of start (latitude, longitude) coordinates.
    /// </summary>
    [JsonPropertyName("endLocation")]
    public string? EndLocation { get; set; }

    /// <summary>
    /// End of the trip in UNIX milliseconds. Ongoing trips are indicated by an endMs value of 9223372036854775807.
    /// </summary>
    [JsonPropertyName("endMs")]
    public long? EndMs { get; set; }

    /// <summary>
    /// Odometer reading (in meters) at the end of the trip. This is read from the vehicle's on-board diagnostics. If Samsara cannot read the vehicle's odometer values from on-board diagnostics, this value will be 0.
    /// </summary>
    [JsonPropertyName("endOdometer")]
    public long? EndOdometer { get; set; }

    /// <summary>
    /// Amount in milliliters of fuel consumed on this trip.
    /// </summary>
    [JsonPropertyName("fuelConsumedMl")]
    public long? FuelConsumedMl { get; set; }

    [JsonPropertyName("startAddress")]
    public V1TripResponseStartAddress? StartAddress { get; set; }

    [JsonPropertyName("startCoordinates")]
    public V1TripResponseStartCoordinates? StartCoordinates { get; set; }

    /// <summary>
    /// Geocoded street address of start (latitude, longitude) coordinates.
    /// </summary>
    [JsonPropertyName("startLocation")]
    public string? StartLocation { get; set; }

    /// <summary>
    /// Beginning of the trip in UNIX milliseconds.
    /// </summary>
    [JsonPropertyName("startMs")]
    public long? StartMs { get; set; }

    /// <summary>
    /// Odometer reading (in meters) at the beginning of the trip. This is read from the vehicle's on-board diagnostics. If Samsara cannot read the vehicle's odometer values from on-board diagnostics, this value will be 0.
    /// </summary>
    [JsonPropertyName("startOdometer")]
    public long? StartOdometer { get; set; }

    /// <summary>
    /// Length in meters trip spent on toll roads.
    /// </summary>
    [JsonPropertyName("tollMeters")]
    public long? TollMeters { get; set; }

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
