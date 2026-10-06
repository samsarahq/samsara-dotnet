using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// A technician attendance shift.
/// </summary>
[Serializable]
public record TechnicianShiftObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Shift start.
    /// </summary>
    [JsonPropertyName("clockInAtTime")]
    public required DateTime ClockInAtTime { get; set; }

    /// <summary>
    /// Surface that recorded clock-in.  Valid values: `api`, `cloud`, `mobile`, `unknown`
    /// </summary>
    [JsonPropertyName("clockInSource")]
    public required TechnicianShiftObjectResponseBodyClockInSource ClockInSource { get; set; }

    /// <summary>
    /// Shift end; omitted while open.
    /// </summary>
    [JsonPropertyName("clockOutAtTime")]
    public DateTime? ClockOutAtTime { get; set; }

    /// <summary>
    /// Surface that recorded clock-out; omitted while open.  Valid values: `api`, `cloud`, `mobile`, `unknown`
    /// </summary>
    [JsonPropertyName("clockOutSource")]
    public TechnicianShiftObjectResponseBodyClockOutSource? ClockOutSource { get; set; }

    /// <summary>
    /// Server-recorded creation time.
    /// </summary>
    [JsonPropertyName("createdAtTime")]
    public required DateTime CreatedAtTime { get; set; }

    /// <summary>
    /// Linked Driver captured when the shift was created.
    /// </summary>
    [JsonPropertyName("driverId")]
    public string? DriverId { get; set; }

    /// <summary>
    /// External identifiers, with at most 30 pairs.
    /// </summary>
    [JsonPropertyName("externalIds")]
    public Dictionary<string, string>? ExternalIds { get; set; }

    /// <summary>
    /// External identifiers, with at most 30 pairs.
    /// </summary>
    [JsonPropertyName("externalTechnicianIds")]
    public Dictionary<string, string>? ExternalTechnicianIds { get; set; }

    /// <summary>
    /// Stable server-generated shift UUID.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// Maintenance-shop Place ID.
    /// </summary>
    [JsonPropertyName("placeId")]
    public string? PlaceId { get; set; }

    /// <summary>
    /// Derived shift status.  Valid values: `inProgress`, `completed`, `unknown`
    /// </summary>
    [JsonPropertyName("status")]
    public required TechnicianShiftObjectResponseBodyStatus Status { get; set; }

    /// <summary>
    /// Last material shift update.
    /// </summary>
    [JsonPropertyName("updatedAtTime")]
    public required DateTime UpdatedAtTime { get; set; }

    /// <summary>
    /// Samsara User captured when the shift was created.
    /// </summary>
    [JsonPropertyName("userId")]
    public string? UserId { get; set; }

    /// <summary>
    /// Server-managed revision. Echo the received value on PATCH.
    /// </summary>
    [JsonPropertyName("version")]
    public required long Version { get; set; }

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
