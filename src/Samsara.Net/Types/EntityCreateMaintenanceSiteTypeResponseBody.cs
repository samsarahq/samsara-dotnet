using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// MaintenanceSite object
/// </summary>
[Serializable]
public record EntityCreateMaintenanceSiteTypeResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// When the maintenance site was archived. Unset when isArchived is false.
    /// </summary>
    [JsonPropertyName("archivedAt")]
    public string? ArchivedAt { get; set; }

    /// <summary>
    /// When the maintenance site was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public string? CreatedAt { get; set; }

    [JsonPropertyName("customAddress")]
    public CreateMaintenanceSiteEntityMaintenanceSiteMaintenanceSiteCustomAddressTypeResponseBody? CustomAddress { get; set; }

    /// <summary>
    /// Description of the maintenance site.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Customer-supplied external identifiers for the site, interchangeable with id in filters. Only included in the response when includeExternalIds is set.
    /// </summary>
    [JsonPropertyName("externalIds")]
    public IEnumerable<CreateMaintenanceSiteEntityMaintenanceSiteMaintenanceSiteExternalIdTypeResponseBody>? ExternalIds { get; set; }

    /// <summary>
    /// Samsara ID for the maintenance site.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Whether the site is archived. Archived sites are no longer active but are retained for historical record.
    /// </summary>
    [JsonPropertyName("isArchived")]
    public bool? IsArchived { get; set; }

    /// <summary>
    /// Name of the maintenance site. Org-unique.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Places this site is linked to. Mutually exclusive with customAddress. At most one entry is accepted today, though the field is an array to allow for future expansion.
    /// </summary>
    [JsonPropertyName("places")]
    public IEnumerable<EntityCreateMaintenanceSitePlaceRefTypeResponseBody>? Places { get; set; }

    /// <summary>
    /// Org-unique 3-character code for the site, used to generate inventory batch numbers.
    /// </summary>
    [JsonPropertyName("siteCode")]
    public string? SiteCode { get; set; }

    /// <summary>
    /// Type of maintenance site, for example central warehouse, maintenance shop, or yard/onsite.  Valid values: `Unknown`, `CentralWarehouse`, `MaintenanceShop`, `MobileServiceVehicle`, `YardOnsite`, `Consignment`, `Other`
    /// </summary>
    [JsonPropertyName("siteType")]
    public EntityCreateMaintenanceSiteTypeResponseBodySiteType? SiteType { get; set; }

    /// <summary>
    /// When the maintenance site was last updated.
    /// </summary>
    [JsonPropertyName("updatedAt")]
    public string? UpdatedAt { get; set; }

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
