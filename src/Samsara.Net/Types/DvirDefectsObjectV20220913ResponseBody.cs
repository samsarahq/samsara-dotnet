using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record DvirDefectsObjectV20220913ResponseBody
{
    /// <summary>
    /// Comment on the defect.
    /// </summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary>
    /// Time when the defect was created. UTC timestamp in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("createdAtTime")]
    public required string CreatedAtTime { get; set; }

    /// <summary>
    /// The type of DVIR defect.
    /// </summary>
    [JsonPropertyName("defectType")]
    public required string DefectType { get; set; }

    /// <summary>
    /// The ID of the defect.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// Signifies if this defect is resolved.
    /// </summary>
    [JsonPropertyName("isResolved")]
    public required bool IsResolved { get; set; }

    /// <summary>
    /// The mechanic notes on this defect.
    /// </summary>
    [JsonPropertyName("mechanicNotes")]
    public string? MechanicNotes { get; set; }

    /// <summary>
    /// Time when mechanic notes were last updated. UTC timestamp in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("mechanicNotesUpdatedAtTime")]
    public string? MechanicNotesUpdatedAtTime { get; set; }

    /// <summary>
    /// Time when this defect was resolved. Will not be returned if the defect is unresolved. UTC timestamp in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("resolvedAtTime")]
    public string? ResolvedAtTime { get; set; }

    [JsonPropertyName("resolvedBy")]
    public DvirResolvedByObjectResponseBody? ResolvedBy { get; set; }

    [JsonPropertyName("trailer")]
    public GoaTrailerTinyResponseResponseBody? Trailer { get; set; }

    [JsonPropertyName("vehicle")]
    public VehicleWithGatewayTinyResponseResponseBody? Vehicle { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
