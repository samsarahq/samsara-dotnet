using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[Serializable]
public record TechnicianShiftsCreateTechnicianShiftRequestBody
{
    /// <summary>
    /// Include nonempty shift and technician external-ID maps. Defaults to false.
    /// </summary>
    [JsonIgnore]
    public bool? IncludeExternalIds { get; set; }

    /// <summary>
    /// Shift start.
    /// </summary>
    [JsonPropertyName("clockInAtTime")]
    public required DateTime ClockInAtTime { get; set; }

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
    /// Owning technician's Samsara User ID.
    /// </summary>
    [JsonPropertyName("userId")]
    public required string UserId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
