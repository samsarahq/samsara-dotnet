using System.Text.Json.Serialization;
using Samsara.Net;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[Serializable]
public record EntityWarrantiesServiceUpdateWarrantyRequestBody
{
    /// <summary>
    /// Unique identifier for the Warranty record.
    /// </summary>
    [JsonIgnore]
    public required string Id { get; set; }

    [JsonPropertyName("baseCoverage")]
    public UpdateWarrantyEntityWarrantyWarrantyCoverageInputTypeRequestBody? BaseCoverage { get; set; }

    /// <summary>
    /// Additional coverage groups defined on this warranty.
    /// </summary>
    [JsonPropertyName("coverages")]
    public IEnumerable<UpdateWarrantyEntityWarrantyWarrantyCoverageInputTypeRequestBody>? Coverages { get; set; }

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
    public IEnumerable<UpdateWarrantyEntityWarrantyWarrantyExternalIdInputTypeRequestBody>? ExternalIds { get; set; }

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
    /// ID of the vendor that provides this warranty.
    /// </summary>
    [JsonPropertyName("vendorId")]
    public string? VendorId { get; set; }

    /// <summary>
    /// Type of warranty, for example manufacturer, extended, other, or unknown.
    /// </summary>
    [JsonPropertyName("warrantyType")]
    public string? WarrantyType { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
