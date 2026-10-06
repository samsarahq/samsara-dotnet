using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Vendor object
/// </summary>
[Serializable]
public record EntityUpdateVendorTypeResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Address of the vendor.
    /// </summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    /// <summary>
    /// Assets this vendor can service. Empty replaces inherited selections; null clears the setting.
    /// </summary>
    [JsonPropertyName("assetAttributeSelections")]
    public IEnumerable<UpdateVendorEntityVendorVendorAssetAttributeSelectionTypeResponseBody>? AssetAttributeSelections { get; set; }

    /// <summary>
    /// People to contact at the vendor.
    /// </summary>
    [JsonPropertyName("contacts")]
    public IEnumerable<UpdateVendorEntityVendorVendorContactTypeResponseBody>? Contacts { get; set; }

    [JsonPropertyName("defaultLaborRatePerHour")]
    public UpdateVendorEntityVendorVendorHourlyMoneyTypeResponseBody? DefaultLaborRatePerHour { get; set; }

    /// <summary>
    /// Email addresses for the vendor.
    /// </summary>
    [JsonPropertyName("emailAddresses")]
    public IEnumerable<string>? EmailAddresses { get; set; }

    /// <summary>
    /// External identifier for the vendor from an external system.
    /// </summary>
    [JsonPropertyName("externalId")]
    public string? ExternalId { get; set; }

    /// <summary>
    /// Customer-supplied external identifiers for the vendor, interchangeable with id in filters. Only included in the response when includeExternalIds is set.
    /// </summary>
    [JsonPropertyName("externalIds")]
    public IEnumerable<UpdateVendorEntityVendorVendorExternalIdTypeResponseBody>? ExternalIds { get; set; }

    /// <summary>
    /// Internal unique identifier for the vendor.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Whether this vendor provides mobile service. When unset, the profile or system default applies.
    /// </summary>
    [JsonPropertyName("isMobile")]
    public bool? IsMobile { get; set; }

    /// <summary>
    /// Whether this vendor location is preferred. When unset, the profile or system default applies.
    /// </summary>
    [JsonPropertyName("isPreferred")]
    public bool? IsPreferred { get; set; }

    /// <summary>
    /// Name of the vendor.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Additional notes about the vendor.
    /// </summary>
    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    /// <summary>
    /// Free-text AP/ERP payee identifier for the vendor. Not a reference to a Samsara entity.
    /// </summary>
    [JsonPropertyName("payeeId")]
    public string? PayeeId { get; set; }

    /// <summary>
    /// Phone numbers for the vendor.
    /// </summary>
    [JsonPropertyName("phoneNumbers")]
    public IEnumerable<string>? PhoneNumbers { get; set; }

    [JsonPropertyName("placeId")]
    public EntityUpdateVendorPlaceRefTypeResponseBody? PlaceId { get; set; }

    /// <summary>
    /// Description of services provided by the vendor.
    /// </summary>
    [JsonPropertyName("servicesProvided")]
    public string? ServicesProvided { get; set; }

    /// <summary>
    /// Own lifecycle status. Defaults to active. Unknown is read-only.  Valid values: `active`, `inactive`, `unknown`
    /// </summary>
    [JsonPropertyName("status")]
    public EntityUpdateVendorTypeResponseBodyStatus? Status { get; set; }

    /// <summary>
    /// Vendor group ID. Null removes membership while preserving explicit overrides.
    /// </summary>
    [JsonPropertyName("vendorGroupId")]
    public string? VendorGroupId { get; set; }

    /// <summary>
    /// User-defined identifier for the vendor.
    /// </summary>
    [JsonPropertyName("vendorId")]
    public string? VendorId { get; set; }

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
