using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Resolved settings; does not change the configured top-level fields.
/// </summary>
[Serializable]
public record VendorPublicResolvedSettingsResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Resolved attribute selections. System default empty.
    /// </summary>
    [JsonPropertyName("assetAttributeSelections")]
    public IEnumerable<VendorPublicAttributeSelectionResponseBody> AssetAttributeSelections { get; set; } =
        new List<VendorPublicAttributeSelectionResponseBody>();

    /// <summary>
    /// system, vendorGroup, vendorLocation, or unknown.
    /// </summary>
    [JsonPropertyName("assetAttributeSelectionsSource")]
    public required string AssetAttributeSelectionsSource { get; set; }

    [JsonPropertyName("defaultLaborRatePerHour")]
    public VendorPublicMoneyResponseBody? DefaultLaborRatePerHour { get; set; }

    /// <summary>
    /// system, vendorGroup, vendorLocation, or unknown.
    /// </summary>
    [JsonPropertyName("defaultLaborRatePerHourSource")]
    public required string DefaultLaborRatePerHourSource { get; set; }

    /// <summary>
    /// Both location and parent, if present, are active.
    /// </summary>
    [JsonPropertyName("isActive")]
    public required bool IsActive { get; set; }

    /// <summary>
    /// Resolved mobile service. System default false.
    /// </summary>
    [JsonPropertyName("isMobile")]
    public required bool IsMobile { get; set; }

    /// <summary>
    /// system, vendorGroup, vendorLocation, or unknown.
    /// </summary>
    [JsonPropertyName("isMobileSource")]
    public required string IsMobileSource { get; set; }

    /// <summary>
    /// Resolved preferred status. System default false.
    /// </summary>
    [JsonPropertyName("isPreferred")]
    public required bool IsPreferred { get; set; }

    /// <summary>
    /// system, vendorGroup, vendorLocation, or unknown.
    /// </summary>
    [JsonPropertyName("isPreferredSource")]
    public required string IsPreferredSource { get; set; }

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
