using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record V1TripResponseTrips
{
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
    public int? DistanceMeters { get; set; }

    /// <summary>
    /// ID of the driver.
    /// </summary>
    [JsonPropertyName("driverId")]
    public int? DriverId { get; set; }

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
    public int? EndMs { get; set; }

    /// <summary>
    /// Odometer reading (in meters) at the end of the trip. This is read from the vehicle's on-board diagnostics. If Samsara cannot read the vehicle's odometer values from on-board diagnostics, this value will be 0.
    /// </summary>
    [JsonPropertyName("endOdometer")]
    public int? EndOdometer { get; set; }

    /// <summary>
    /// Amount in milliliters of fuel consumed on this trip.
    /// </summary>
    [JsonPropertyName("fuelConsumedMl")]
    public int? FuelConsumedMl { get; set; }

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
    public int? StartMs { get; set; }

    /// <summary>
    /// Odometer reading (in meters) at the beginning of the trip. This is read from the vehicle's on-board diagnostics. If Samsara cannot read the vehicle's odometer values from on-board diagnostics, this value will be 0.
    /// </summary>
    [JsonPropertyName("startOdometer")]
    public int? StartOdometer { get; set; }

    /// <summary>
    /// Length in meters trip spent on toll roads.
    /// </summary>
    [JsonPropertyName("tollMeters")]
    public int? TollMeters { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
