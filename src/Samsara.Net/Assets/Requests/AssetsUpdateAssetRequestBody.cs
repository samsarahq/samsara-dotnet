using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Assets;

public record AssetsUpdateAssetRequestBody
{
    /// <summary>
    /// A filter selecting a single asset by id.
    /// </summary>
    [JsonIgnore]
    public required string Id { get; set; }

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
    /// The OEM/manufacturer of the asset. Updates to this field are restricted.
    /// </summary>
    [JsonPropertyName("make")]
    public string? Make { get; set; }

    /// <summary>
    /// The model of the asset. Updates to this field are restricted.
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
    public AssetsUpdateAssetRequestBodyRegulationMode? RegulationMode { get; set; }

    /// <summary>
    /// The serial number of the asset. This can be an internal serial number or used to hold legacy VIN/PIN numbers such as ones of shorter lengths.
    /// </summary>
    [JsonPropertyName("serialNumber")]
    public string? SerialNumber { get; set; }

    /// <summary>
    /// The operational context in which the asset interacts with the Samsara system. Examples: Vehicle (eg: truck, bus...), Trailer (eg: dry van, reefer, flatbed...), Powered Equipment (eg: dozer, crane...), Unpowered Equipment (eg: container, dumpster...), or Uncategorized.  Valid values: `uncategorized`, `trailer`, `equipment`, `unpowered`, `vehicle`
    /// </summary>
    [JsonPropertyName("type")]
    public AssetsUpdateAssetRequestBodyType? Type { get; set; }

    /// <summary>
    /// The unique 17-digit VIN (Vehicle Identification Number) or PIN (Product Identification Number) of the asset.
    /// </summary>
    [JsonPropertyName("vin")]
    public string? Vin { get; set; }

    /// <summary>
    /// The model year of the asset. Updates to this field are restricted.
    /// </summary>
    [JsonPropertyName("year")]
    public long? Year { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
