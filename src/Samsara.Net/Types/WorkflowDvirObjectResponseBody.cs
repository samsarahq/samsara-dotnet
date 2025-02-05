using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record WorkflowDvirObjectResponseBody
{
    [JsonPropertyName("authorSignature")]
    public required WorkflowAuthorSignatureObjectResponseBody AuthorSignature { get; set; }

    /// <summary>
    /// Defects registered for the DVIR.
    /// </summary>
    [JsonPropertyName("defects")]
    public IEnumerable<DvirDefectsObjectV20220913ResponseBody>? Defects { get; set; }

    /// <summary>
    /// Time when the driver signed and completed this DVIR. UTC timestamp in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("endTime")]
    public required string EndTime { get; set; }

    /// <summary>
    /// Optional string if your jurisdiction requires a location of the DVIR.
    /// </summary>
    [JsonPropertyName("formattedLocation")]
    public string? FormattedLocation { get; set; }

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
    /// Indicates if a defect needs correction.
    /// </summary>
    [JsonPropertyName("needsCorrection")]
    public required bool NeedsCorrection { get; set; }

    /// <summary>
    /// The odometer reading in meters.
    /// </summary>
    [JsonPropertyName("odometerMeters")]
    public long? OdometerMeters { get; set; }

    /// <summary>
    /// The condition of vehicle on which DVIR was done.  Valid values: `safe`, `unsafe`, `resolved`
    /// </summary>
    [JsonPropertyName("safetyStatus")]
    public required WorkflowDvirObjectResponseBodySafetyStatus SafetyStatus { get; set; }

    [JsonPropertyName("secondSignature")]
    public WorkflowAuthorSignatureObjectResponseBody? SecondSignature { get; set; }

    /// <summary>
    /// Time when driver began filling out this DVIR in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("startTime")]
    public required string StartTime { get; set; }

    [JsonPropertyName("thirdSignature")]
    public WorkflowAuthorSignatureObjectResponseBody? ThirdSignature { get; set; }

    [JsonPropertyName("trailer")]
    public GoaTrailerTinyResponseResponseBody? Trailer { get; set; }

    /// <summary>
    /// Inspection type of the DVIR.  Valid values: `preTrip`, `postTrip`, `mechanic`, `unspecified`
    /// </summary>
    [JsonPropertyName("type")]
    public required WorkflowDvirObjectResponseBodyType Type { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
