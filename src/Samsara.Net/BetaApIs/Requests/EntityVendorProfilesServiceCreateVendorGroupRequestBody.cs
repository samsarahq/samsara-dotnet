using System.Text.Json.Serialization;
using Samsara.Net;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[Serializable]
public record EntityVendorProfilesServiceCreateVendorGroupRequestBody
{
    /// <summary>
    /// Include externalIds in the response. Defaults to false.
    /// </summary>
    [JsonIgnore]
    public bool? IncludeExternalIds { get; set; }

    /// <summary>
    /// Assets this vendor can service. Empty replaces inherited selections; null clears the setting.
    /// </summary>
    [JsonPropertyName("assetAttributeSelections")]
    public IEnumerable<CreateVendorGroupEntityVendorProfileVendorAssetAttributeSelectionInputTypeRequestBody>? AssetAttributeSelections { get; set; }

    [JsonPropertyName("defaultLaborRatePerHour")]
    public CreateVendorGroupEntityVendorProfileVendorHourlyMoneyInputTypeRequestBody? DefaultLaborRatePerHour { get; set; }

    /// <summary>
    /// External identifiers belonging to this vendor group.
    /// </summary>
    [JsonPropertyName("externalIds")]
    public IEnumerable<CreateVendorGroupEntityVendorProfileVendorGroupExternalIdInputTypeRequestBody>? ExternalIds { get; set; }

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
    public required string Name { get; set; }

    [JsonPropertyName("primaryCorporateContact")]
    public CreateVendorGroupEntityVendorProfileVendorGroupPrimaryCorporateContactInputTypeRequestBody? PrimaryCorporateContact { get; set; }

    /// <summary>
    /// Own lifecycle status. Defaults to active. Unknown is read-only.  Valid values: `active`, `inactive`, `unknown`
    /// </summary>
    [JsonPropertyName("status")]
    public EntityVendorProfilesServiceCreateVendorGroupRequestBodyStatus? Status { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
