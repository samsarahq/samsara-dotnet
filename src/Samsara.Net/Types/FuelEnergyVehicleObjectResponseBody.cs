using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record FuelEnergyVehicleObjectResponseBody
{
    /// <summary>
    /// Type of energy used by the vehicle  Valid values: `fuel`, `hybrid`, `electric`
    /// </summary>
    [JsonPropertyName("energyType")]
    public required FuelEnergyVehicleObjectResponseBodyEnergyType EnergyType { get; set; }

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
    /// Name of the vehicle
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
