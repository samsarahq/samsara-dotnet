using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record VehicleSensorConfigurationDoorResponseBody
{
    /// <summary>
    /// Position of the door monitor on the vehicle  Valid values: `back`, `left`, `right`
    /// </summary>
    [JsonPropertyName("position")]
    public required VehicleSensorConfigurationDoorResponseBodyPosition Position { get; set; }

    [JsonPropertyName("sensor")]
    public required SensorResponseBody Sensor { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
