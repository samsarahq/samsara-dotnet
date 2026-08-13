using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// UpdateWarrantyEntityWarrantyWarrantyCoverageInput object
/// </summary>
[Serializable]
public record UpdateWarrantyEntityWarrantyWarrantyCoverageInputTypeRequestBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Description of what this coverage group covers.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Coverage length in days. Mutually exclusive with duration in months.
    /// </summary>
    [JsonPropertyName("durationDays")]
    public long? DurationDays { get; set; }

    /// <summary>
    /// Coverage length in months. Mutually exclusive with duration in days.
    /// </summary>
    [JsonPropertyName("durationMonths")]
    public long? DurationMonths { get; set; }

    /// <summary>
    /// Coverage length by engine hours since the coverage start.
    /// </summary>
    [JsonPropertyName("engineDurationHours")]
    public long? EngineDurationHours { get; set; }

    /// <summary>
    /// Items explicitly excluded from this coverage group.
    /// </summary>
    [JsonPropertyName("exclusions")]
    public IEnumerable<UpdateWarrantyEntityWarrantyWarrantyCoverageItemInputTypeRequestBody>? Exclusions { get; set; }

    /// <summary>
    /// Items explicitly covered by this coverage group.
    /// </summary>
    [JsonPropertyName("inclusions")]
    public IEnumerable<UpdateWarrantyEntityWarrantyWarrantyCoverageItemInputTypeRequestBody>? Inclusions { get; set; }

    /// <summary>
    /// When true, the coverage never expires by mileage and the odometer distance is ignored.
    /// </summary>
    [JsonPropertyName("isOdometerDistanceUnlimited")]
    public bool? IsOdometerDistanceUnlimited { get; set; }

    /// <summary>
    /// Name of the coverage group.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Free-form notes about this coverage group.
    /// </summary>
    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    /// <summary>
    /// Coverage length by distance travelled since the coverage start. Measured in meters.
    /// </summary>
    [JsonPropertyName("odometerDistanceMeters")]
    public long? OdometerDistanceMeters { get; set; }

    /// <summary>
    /// Engine hours at the start of this coverage.
    /// </summary>
    [JsonPropertyName("startEngineHours")]
    public long? StartEngineHours { get; set; }

    /// <summary>
    /// Odometer reading at the start of this coverage. Measured in meters.
    /// </summary>
    [JsonPropertyName("startOdometerMeters")]
    public long? StartOdometerMeters { get; set; }

    /// <summary>
    /// Start time of this coverage.
    /// </summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

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
