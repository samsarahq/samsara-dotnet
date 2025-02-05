using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record VehicleSensorConfigurationResponseBody
{
    /// <summary>
    /// Configured sensor areas on the vehicle with its associated sensors
    /// </summary>
    [JsonPropertyName("areas")]
    public IEnumerable<VehicleSensorConfigurationAreaResponseBody>? Areas { get; set; }

    /// <summary>
    /// Configured door monitors on the vehicle
    /// </summary>
    [JsonPropertyName("doors")]
    public IEnumerable<VehicleSensorConfigurationDoorResponseBody>? Doors { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
