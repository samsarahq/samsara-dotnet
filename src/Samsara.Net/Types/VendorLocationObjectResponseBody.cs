using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// A maintenance vendor location linked to a Place.
/// </summary>
[Serializable]
public record VendorLocationObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The linked Place's Address ID, equal to data.id returned by the public Addresses API. The Place owns the location's name, address, and notes. Use this addressId as {id} in GET /addresses/{id} to retrieve data.name, data.formattedAddress, and data.notes, and PATCH /addresses/{id} to update name, formattedAddress, and notes. These calls require Read Addresses and Write Addresses permissions, respectively.
    /// </summary>
    [JsonPropertyName("addressId")]
    public string? AddressId { get; set; }

    /// <summary>
    /// Configured asset attributes. An empty array is explicit; omission inherits.
    /// </summary>
    [JsonPropertyName("assetAttributeSelections")]
    public IEnumerable<VendorPublicAttributeSelectionResponseBody>? AssetAttributeSelections { get; set; }

    /// <summary>
    /// Category UUIDs for this vendor. Use the Vendor Categories endpoint to resolve names.
    /// </summary>
    [JsonPropertyName("categoryIds")]
    public IEnumerable<string> CategoryIds { get; set; } = new List<string>();

    [JsonPropertyName("defaultLaborRatePerHour")]
    public VendorPublicMoneyResponseBody? DefaultLaborRatePerHour { get; set; }

    /// <summary>
    /// A map of external ids
    /// </summary>
    [JsonPropertyName("externalIds")]
    public Dictionary<string, string>? ExternalIds { get; set; }

    /// <summary>
    /// Unique UUID of the vendor location.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// Explicit mobile-service override; omitted when inherited.
    /// </summary>
    [JsonPropertyName("isMobile")]
    public bool? IsMobile { get; set; }

    /// <summary>
    /// Explicit preferred override; omitted when inherited.
    /// </summary>
    [JsonPropertyName("isPreferred")]
    public bool? IsPreferred { get; set; }

    /// <summary>
    /// Parent vendor UUID, when configured.
    /// </summary>
    [JsonPropertyName("parentVendorId")]
    public string? ParentVendorId { get; set; }

    /// <summary>
    /// The vendor's accounts-payable/ERP payee ID.
    /// </summary>
    [JsonPropertyName("payeeId")]
    public string? PayeeId { get; set; }

    [JsonPropertyName("resolvedSettings")]
    public VendorPublicResolvedSettingsResponseBody? ResolvedSettings { get; set; }

    /// <summary>
    /// Description of services provided by the vendor.
    /// </summary>
    [JsonPropertyName("servicesProvided")]
    public string? ServicesProvided { get; set; }

    /// <summary>
    /// Own lifecycle status: active, inactive, or unknown. Defaults to active.
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>
    /// The vendor's legacy vendor ID from the source system. Multiple vendor locations may share the same vendorId if they belong to the same parent company.
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
