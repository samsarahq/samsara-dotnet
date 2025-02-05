using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record VehicleResponseResponseBody
{
    /// <summary>
    /// The type of the asset.  Valid values: `uncategorized`, `trailer`, `equipment`, `unpowered`, `vehicle`
    /// </summary>
    [JsonPropertyName("assetType")]
    public VehicleResponseResponseBodyAssetType? AssetType { get; set; }

    /// <summary>
    /// A map of external ids
    /// </summary>
    [JsonPropertyName("externalIds")]
    public Dictionary<string, string>? ExternalIds { get; set; }

    /// <summary>
    /// ID of the vehicle
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// The license plate of the vehicle.
    /// </summary>
    [JsonPropertyName("licensePlate")]
    public string? LicensePlate { get; set; }

    /// <summary>
    /// Name of the vehicle
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The VIN of the vehicle.
    /// </summary>
    [JsonPropertyName("vehicleVin")]
    public string? VehicleVin { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
