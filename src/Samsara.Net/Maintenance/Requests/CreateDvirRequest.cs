using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Maintenance;

public record CreateDvirRequest
{
    /// <summary>
    /// Samsara user ID of the mechanic creating the DVIR.
    /// </summary>
    [JsonPropertyName("authorId")]
    public required string AuthorId { get; set; }

    /// <summary>
    /// The license plate of this vehicle.
    /// </summary>
    [JsonPropertyName("licensePlate")]
    public string? LicensePlate { get; set; }

    /// <summary>
    /// Optional string if your jurisdiction requires a location of the DVIR.
    /// </summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// The mechanics notes on the DVIR.
    /// </summary>
    [JsonPropertyName("mechanicNotes")]
    public string? MechanicNotes { get; set; }

    /// <summary>
    /// The odometer reading in meters.
    /// </summary>
    [JsonPropertyName("odometerMeters")]
    public int? OdometerMeters { get; set; }

    /// <summary>
    /// Array of ids for defects being resolved with this DVIR.
    /// </summary>
    [JsonPropertyName("resolvedDefectIds")]
    public IEnumerable<string>? ResolvedDefectIds { get; set; }

    /// <summary>
    /// Whether or not this vehicle or trailer is safe to drive.
    /// </summary>
    [JsonPropertyName("safetyStatus")]
    public required CreateDvirRequestSafetyStatus SafetyStatus { get; set; }

    /// <summary>
    /// Id of trailer being inspected. Either vehicleId or trailerId must be provided.
    /// </summary>
    [JsonPropertyName("trailerId")]
    public string? TrailerId { get; set; }

    /// <summary>
    /// Only type 'mechanic' is currently accepted.
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }

    /// <summary>
    /// Id of vehicle being inspected. Either vehicleId or trailerId must be provided.
    /// </summary>
    [JsonPropertyName("vehicleId")]
    public string? VehicleId { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
