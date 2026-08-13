using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Warranty object
/// </summary>
[Serializable]
public record EntityListWarrantiesTypeResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("baseCoverage")]
    public ListWarrantiesEntityWarrantyWarrantyCoverageTypeResponseBody? BaseCoverage { get; set; }

    /// <summary>
    /// Additional coverage groups defined on this warranty.
    /// </summary>
    [JsonPropertyName("coverages")]
    public IEnumerable<ListWarrantiesEntityWarrantyWarrantyCoverageTypeResponseBody>? Coverages { get; set; }

    /// <summary>
    /// When the warranty was created.
    /// </summary>
    [JsonPropertyName("createdAtTime")]
    public string? CreatedAtTime { get; set; }

    /// <summary>
    /// Description of the warranty.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Warranty length in days. Mutually exclusive with duration in months.
    /// </summary>
    [JsonPropertyName("durationDays")]
    public long? DurationDays { get; set; }

    /// <summary>
    /// Warranty length in months. Mutually exclusive with duration in days.
    /// </summary>
    [JsonPropertyName("durationMonths")]
    public long? DurationMonths { get; set; }

    /// <summary>
    /// Warranty length by engine hours since the warranty start.
    /// </summary>
    [JsonPropertyName("engineDurationHours")]
    public long? EngineDurationHours { get; set; }

    /// <summary>
    /// Customer-supplied external identifiers for the warranty, interchangeable with id in filters. Only included in the response when includeExternalIds is set.
    /// </summary>
    [JsonPropertyName("externalIds")]
    public IEnumerable<ListWarrantiesEntityWarrantyWarrantyExternalIdTypeResponseBody>? ExternalIds { get; set; }

    /// <summary>
    /// Samsara ID for the warranty.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Name of the warranty.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Warranty length by distance travelled since the warranty start. Measured in meters.
    /// </summary>
    [JsonPropertyName("odometerDistanceMeters")]
    public long? OdometerDistanceMeters { get; set; }

    /// <summary>
    /// When the warranty was last updated.
    /// </summary>
    [JsonPropertyName("updatedAtTime")]
    public string? UpdatedAtTime { get; set; }

    [JsonPropertyName("vendor")]
    public EntityListWarrantiesVendorRefTypeResponseBody? Vendor { get; set; }

    /// <summary>
    /// Type of warranty, for example manufacturer, extended, other, or unknown.
    /// </summary>
    [JsonPropertyName("warrantyType")]
    public string? WarrantyType { get; set; }

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
