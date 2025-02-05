using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record Dvir
{
    [JsonPropertyName("authorSignature")]
    public DvirAuthorSignature? AuthorSignature { get; set; }

    /// <summary>
    /// Time when driver signed and completed this DVIR. UTC timestamp in RFC 3339 format. Example: `2020-01-27T07:06:25Z`.
    /// </summary>
    [JsonPropertyName("endTime")]
    public string? EndTime { get; set; }

    /// <summary>
    /// Unique Samsara ID for the DVIR.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("licensePlate")]
    public string? LicensePlate { get; set; }

    [JsonPropertyName("location")]
    public string? Location { get; set; }

    [JsonPropertyName("mechanicNotes")]
    public string? MechanicNotes { get; set; }

    [JsonPropertyName("odometerMeters")]
    public int? OdometerMeters { get; set; }

    /// <summary>
    /// The condition of vehicle on which DVIR was done. Valid values: `safe`, `unsafe`, `resolved`.
    /// </summary>
    [JsonPropertyName("safetyStatus")]
    public DvirSafetyStatus? SafetyStatus { get; set; }

    [JsonPropertyName("secondSignature")]
    public DvirSecondSignature? SecondSignature { get; set; }

    /// <summary>
    /// Time when driver began filling out this DVIR. UTC timestamp in RFC 3339 format. Example: `2020-01-27T07:06:25Z`.
    /// </summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    [JsonPropertyName("thirdSignature")]
    public DvirThirdSignature? ThirdSignature { get; set; }

    [JsonPropertyName("trailer")]
    public DvirTrailer? Trailer { get; set; }

    [JsonPropertyName("trailerDefects")]
    public IEnumerable<DvirTrailerDefectsItems>? TrailerDefects { get; set; }

    /// <summary>
    /// The name of the trailer the DVIR was submitted for.  Only included for tractor+trailer DVIRs.
    /// </summary>
    [JsonPropertyName("trailerName")]
    public string? TrailerName { get; set; }

    /// <summary>
    /// Inspection type of the DVIR. Valid values: `preTrip`, `postTrip`, `mechanic`, `unspecified`.
    /// </summary>
    [JsonPropertyName("type")]
    public DvirType? Type { get; set; }

    [JsonPropertyName("vehicle")]
    public DvirVehicle? Vehicle { get; set; }

    [JsonPropertyName("vehicleDefects")]
    public IEnumerable<DvirTrailerDefectsItems>? VehicleDefects { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
