using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Beta.Assets;

public record AssetsCreateAssetRequestBody
{
    /// <summary>
    /// A map of external ids
    /// </summary>
    [JsonPropertyName("externalIds")]
    public Dictionary<string, string>? ExternalIds { get; set; }

    /// <summary>
    /// The license plate of the asset.
    /// </summary>
    [JsonPropertyName("licensePlate")]
    public string? LicensePlate { get; set; }

    /// <summary>
    /// The manufacturer of the asset. (If a VIN is entered and the system detects it is registered to a different manufacturer than provided an error will be returned).
    /// </summary>
    [JsonPropertyName("make")]
    public string? Make { get; set; }

    /// <summary>
    /// The manufacturer model of the asset. (If a VIN is entered and the system detects it is registered to a different model than provided an error will be returned).
    /// </summary>
    [JsonPropertyName("model")]
    public string? Model { get; set; }

    /// <summary>
    /// The human-readable name of the asset. This is set by a fleet administrator and will appear in both Samsara’s cloud dashboard as well as the Samsara Driver mobile app. By default, this name is the serial number of the Samsara Asset Gateway. It can be set or updated through the Samsara Dashboard or through the API at any time.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// These are generic notes about the asset. Can be set or updated through the Samsara Dashboard or the API at any time.
    /// </summary>
    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    /// <summary>
    /// Whether or not the asset is regulated, unregulated (non-CMV), or a mixed use unregulated asset. Primarily used with vehicles.  Valid values: `mixed`, `regulated`, `unregulated`
    /// </summary>
    [JsonPropertyName("regulationMode")]
    public AssetsCreateAssetRequestBodyRegulationMode? RegulationMode { get; set; }

    /// <summary>
    /// The serial number of the asset.
    /// </summary>
    [JsonPropertyName("serialNumber")]
    public string? SerialNumber { get; set; }

    /// <summary>
    /// The operational context in which the asset interacts with the Samsara system. Examples: Vehicle (eg: truck, bus...), Trailer (eg: dry van, reefer, flatbed...), Powered Equipment (eg: dozer, crane...), Unpowered Equipment (eg: container, dumpster...), or Uncategorized.  Valid values: `uncategorized`, `trailer`, `equipment`, `unpowered`, `vehicle`
    /// </summary>
    [JsonPropertyName("type")]
    public AssetsCreateAssetRequestBodyType? Type { get; set; }

    /// <summary>
    /// The vehicle identification number of the asset.
    /// </summary>
    [JsonPropertyName("vin")]
    public string? Vin { get; set; }

    /// <summary>
    /// The year of manufacture of the asset.  (If a VIN is entered and the system detects it is registered to a different year than provided an error will be returned).
    /// </summary>
    [JsonPropertyName("year")]
    public long? Year { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
