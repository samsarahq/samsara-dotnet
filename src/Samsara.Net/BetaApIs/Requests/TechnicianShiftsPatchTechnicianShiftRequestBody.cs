using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[Serializable]
public record TechnicianShiftsPatchTechnicianShiftRequestBody
{
    /// <summary>
    /// Include nonempty shift and technician external-ID maps. Defaults to false.
    /// </summary>
    [JsonIgnore]
    public bool? IncludeExternalIds { get; set; }

    /// <summary>
    /// Shift UUID or key:value alias.
    /// </summary>
    [JsonIgnore]
    public required string Id { get; set; }

    /// <summary>
    /// Corrected shift start.
    /// </summary>
    [JsonPropertyName("clockInAtTime")]
    public DateTime? ClockInAtTime { get; set; }

    /// <summary>
    /// Shift end, strictly after start.
    /// </summary>
    [JsonPropertyName("clockOutAtTime")]
    public DateTime? ClockOutAtTime { get; set; }

    /// <summary>
    /// External identifiers, with at most 30 pairs.
    /// </summary>
    [JsonPropertyName("externalIds")]
    public Dictionary<string, string>? ExternalIds { get; set; }

    /// <summary>
    /// Maintenance-shop Place ID.
    /// </summary>
    [JsonPropertyName("placeId")]
    public string? PlaceId { get; set; }

    /// <summary>
    /// Expected revision from the last response; stale material changes return 409.
    /// </summary>
    [JsonPropertyName("version")]
    public required long Version { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
