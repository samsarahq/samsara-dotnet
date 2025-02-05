using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record DvirStreamResponseDataResponseBody
{
    [JsonPropertyName("authorSignature")]
    public required AuthorSignatureObjectResponseBody AuthorSignature { get; set; }

    /// <summary>
    /// IDs of defects registered for the DVIR.
    /// </summary>
    [JsonPropertyName("defectIds")]
    public IEnumerable<string>? DefectIds { get; set; }

    /// <summary>
    /// Time when driver created DVIR. UTC timestamp in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("dvirSubmissionBeginTime")]
    public required string DvirSubmissionBeginTime { get; set; }

    /// <summary>
    /// Time when driver submitted the DVIR. UTC timestamp in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("dvirSubmissionTime")]
    public required string DvirSubmissionTime { get; set; }

    [JsonPropertyName("formattedAddress")]
    public string? FormattedAddress { get; set; }

    /// <summary>
    /// The unique id of the DVIR
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// The mechanics notes on the DVIR.
    /// </summary>
    [JsonPropertyName("mechanicNotes")]
    public string? MechanicNotes { get; set; }

    /// <summary>
    /// The odometer reading in meters.
    /// </summary>
    [JsonPropertyName("odometerMeters")]
    public long? OdometerMeters { get; set; }

    /// <summary>
    /// The condition of vehicle on which DVIR was done.  Valid values: `unknown`, `safe`, `unsafe`, `resolved`
    /// </summary>
    [JsonPropertyName("safetyStatus")]
    public DvirStreamResponseDataResponseBodySafetyStatus? SafetyStatus { get; set; }

    [JsonPropertyName("secondSignature")]
    public AuthorSignatureObjectResponseBody? SecondSignature { get; set; }

    [JsonPropertyName("thirdSignature")]
    public AuthorSignatureObjectResponseBody? ThirdSignature { get; set; }

    [JsonPropertyName("trailer")]
    public TrailerDvirObjectResponseBody? Trailer { get; set; }

    /// <summary>
    /// Inspection type of the DVIR.  Valid values: `preTrip`, `postTrip`, `mechanic`, `unspecified`
    /// </summary>
    [JsonPropertyName("type")]
    public required DvirStreamResponseDataResponseBodyType Type { get; set; }

    /// <summary>
    /// Time of any DVIR updates. UTC timestamp in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("updatedAtTime")]
    public required string UpdatedAtTime { get; set; }

    [JsonPropertyName("vehicle")]
    public VehicleDvirObjectResponseBody? Vehicle { get; set; }

    /// <summary>
    /// List of walkaround photos
    /// </summary>
    [JsonPropertyName("walkaroundPhotos")]
    public IEnumerable<WalkaroundPhotoObjectResponseBody>? WalkaroundPhotos { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
