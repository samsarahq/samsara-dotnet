using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// VendorProfile object
/// </summary>
[Serializable]
public record EntityCreateVendorGroupTypeResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Assets this vendor can service. Empty replaces inherited selections; null clears the setting.
    /// </summary>
    [JsonPropertyName("assetAttributeSelections")]
    public IEnumerable<CreateVendorGroupEntityVendorProfileVendorAssetAttributeSelectionTypeResponseBody>? AssetAttributeSelections { get; set; }

    /// <summary>
    /// Time when the vendor profile was created.
    /// </summary>
    [JsonPropertyName("createdAtTime")]
    public string? CreatedAtTime { get; set; }

    [JsonPropertyName("defaultLaborRatePerHour")]
    public CreateVendorGroupEntityVendorProfileVendorHourlyMoneyTypeResponseBody? DefaultLaborRatePerHour { get; set; }

    /// <summary>
    /// External identifiers belonging to this vendor group.
    /// </summary>
    [JsonPropertyName("externalIds")]
    public IEnumerable<CreateVendorGroupEntityVendorProfileVendorGroupExternalIdTypeResponseBody>? ExternalIds { get; set; }

    /// <summary>
    /// Unique identifier for the vendor profile. Leave blank to create a profile.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Whether vendor locations inherit mobile service as their default.
    /// </summary>
    [JsonPropertyName("isMobile")]
    public bool? IsMobile { get; set; }

    /// <summary>
    /// Default preferred status inherited by vendor locations.
    /// </summary>
    [JsonPropertyName("isPreferred")]
    public bool? IsPreferred { get; set; }

    /// <summary>
    /// Name of the vendor profile.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("primaryCorporateContact")]
    public CreateVendorGroupEntityVendorProfileVendorGroupPrimaryCorporateContactTypeResponseBody? PrimaryCorporateContact { get; set; }

    /// <summary>
    /// Own lifecycle status. Defaults to active. Unknown is read-only.  Valid values: `active`, `inactive`, `unknown`
    /// </summary>
    [JsonPropertyName("status")]
    public EntityCreateVendorGroupTypeResponseBodyStatus? Status { get; set; }

    /// <summary>
    /// Time when the vendor profile was last updated.
    /// </summary>
    [JsonPropertyName("updatedAtTime")]
    public string? UpdatedAtTime { get; set; }

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
