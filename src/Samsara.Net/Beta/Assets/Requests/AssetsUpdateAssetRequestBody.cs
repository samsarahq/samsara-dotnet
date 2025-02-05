using Samsara.Net.Core;

namespace Samsara.Net.Beta.Assets;

public record AssetsUpdateAssetRequestBody
{
    /// <summary>
    /// A filter selecting a single asset by id.
    /// </summary>
    public required string Id { get; set; }

    /// <summary>
    /// A map of external ids
    /// </summary>
    public Dictionary<string, string>? ExternalIds { get; set; }

    /// <summary>
    /// The license plate of the asset.
    /// </summary>
    public string? LicensePlate { get; set; }

    /// <summary>
    /// The manufacturer of the asset. (If a VIN is entered and the system detects it is registered to a different manufacturer than provided an error will be returned).
    /// </summary>
    public string? Make { get; set; }

    /// <summary>
    /// The manufacturer model of the asset. (If a VIN is entered and the system detects it is registered to a different model than provided an error will be returned).
    /// </summary>
    public string? Model { get; set; }

    /// <summary>
    /// The human-readable name of the asset. This is set by a fleet administrator and will appear in both Samsara’s cloud dashboard as well as the Samsara Driver mobile app. By default, this name is the serial number of the Samsara Asset Gateway. It can be set or updated through the Samsara Dashboard or through the API at any time.
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// These are generic notes about the asset. Can be set or updated through the Samsara Dashboard or the API at any time.
    /// </summary>
    public string? Notes { get; set; }

    /// <summary>
    /// Whether or not the asset is regulated, unregulated (non-CMV), or a mixed use unregulated asset. Primarily used with vehicles.  Valid values: `mixed`, `regulated`, `unregulated`
    /// </summary>
    public AssetsUpdateAssetRequestBodyRegulationMode? RegulationMode { get; set; }

    /// <summary>
    /// The serial number of the asset.
    /// </summary>
    public string? SerialNumber { get; set; }

    /// <summary>
    /// The operational context in which the asset interacts with the Samsara system. Examples: Vehicle (eg: truck, bus...), Trailer (eg: dry van, reefer, flatbed...), Powered Equipment (eg: dozer, crane...), Unpowered Equipment (eg: container, dumpster...), or Uncategorized.  Valid values: `uncategorized`, `trailer`, `equipment`, `unpowered`, `vehicle`
    /// </summary>
    public AssetsUpdateAssetRequestBodyType? Type { get; set; }

    /// <summary>
    /// The vehicle identification number of the asset.
    /// </summary>
    public string? Vin { get; set; }

    /// <summary>
    /// The year of manufacture of the asset.  (If a VIN is entered and the system detects it is registered to a different year than provided an error will be returned).
    /// </summary>
    public long? Year { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
