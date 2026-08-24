using System.Text.Json.Serialization;
using Samsara.Net;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[Serializable]
public record EntityMaintenanceSitesServiceCreateMaintenanceSiteRequestBody
{
    [JsonPropertyName("customAddress")]
    public CreateMaintenanceSiteEntityMaintenanceSiteMaintenanceSiteCustomAddressInputTypeRequestBody? CustomAddress { get; set; }

    /// <summary>
    /// Description of the maintenance site.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Customer-supplied external identifiers for the site, interchangeable with id in filters. Only included in the response when includeExternalIds is set.
    /// </summary>
    [JsonPropertyName("externalIds")]
    public IEnumerable<CreateMaintenanceSiteEntityMaintenanceSiteMaintenanceSiteExternalIdInputTypeRequestBody>? ExternalIds { get; set; }

    /// <summary>
    /// Name of the maintenance site. Org-unique.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Places this site is linked to. Mutually exclusive with customAddress. At most one entry is accepted today, though the field is an array to allow for future expansion.
    /// </summary>
    [JsonPropertyName("placeIds")]
    public IEnumerable<string>? PlaceIds { get; set; }

    /// <summary>
    /// Org-unique 3-character code for the site, used to generate inventory batch numbers.
    /// </summary>
    [JsonPropertyName("siteCode")]
    public required string SiteCode { get; set; }

    /// <summary>
    /// Type of maintenance site, for example central warehouse, maintenance shop, or yard/onsite.  Valid values: `Unknown`, `CentralWarehouse`, `MaintenanceShop`, `MobileServiceVehicle`, `YardOnsite`, `Consignment`, `Other`
    /// </summary>
    [JsonPropertyName("siteType")]
    public required EntityMaintenanceSitesServiceCreateMaintenanceSiteRequestBodySiteType SiteType { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
