using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record V1VehicleLocation
{
    /// <summary>
    /// The ID of the driver currently assigned to this vehicle.
    /// </summary>
    [JsonPropertyName("driverId")]
    public int? DriverId { get; set; }

    /// <summary>
    /// Heading in degrees.
    /// </summary>
    [JsonPropertyName("heading")]
    public double? Heading { get; set; }

    /// <summary>
    /// ID of the vehicle.
    /// </summary>
    [JsonPropertyName("id")]
    public required long Id { get; set; }

    /// <summary>
    /// Latitude in decimal degrees.
    /// </summary>
    [JsonPropertyName("latitude")]
    public double? Latitude { get; set; }

    /// <summary>
    /// Text representation of nearest identifiable location to (latitude, longitude) coordinates.
    /// </summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// Longitude in decimal degrees.
    /// </summary>
    [JsonPropertyName("longitude")]
    public double? Longitude { get; set; }

    /// <summary>
    /// Name of the vehicle.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The number of meters reported by the odometer.
    /// </summary>
    [JsonPropertyName("odometerMeters")]
    public long? OdometerMeters { get; set; }

    /// <summary>
    /// The source of data for odometerMeters. Will be either GPS or OBD
    /// </summary>
    [JsonPropertyName("odometerType")]
    public V1VehicleLocationOdometerType? OdometerType { get; set; }

    /// <summary>
    /// Whether or not a trip is currently in progress for this vehicle. More information available via /fleet/trips endpoint.
    /// </summary>
    [JsonPropertyName("onTrip")]
    public bool? OnTrip { get; set; }

    /// <summary>
    /// A list of currently active route IDs that the vehicle is in.
    /// </summary>
    [JsonPropertyName("routeIds")]
    public IEnumerable<long>? RouteIds { get; set; }

    /// <summary>
    /// Speed in miles per hour.
    /// </summary>
    [JsonPropertyName("speed")]
    public double? Speed { get; set; }

    /// <summary>
    /// The time the reported location was logged, reported as a UNIX timestamp in milliseconds.
    /// </summary>
    [JsonPropertyName("time")]
    public int? Time { get; set; }

    /// <summary>
    /// Vehicle Identification Number (VIN) of the vehicle.
    /// </summary>
    [JsonPropertyName("vin")]
    public string? Vin { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
