using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record VehicleSensorConfigurationAreaResponseBody
{
    [JsonPropertyName("cargoSensors")]
    public IEnumerable<SensorResponseBody>? CargoSensors { get; set; }

    [JsonPropertyName("humiditySensors")]
    public IEnumerable<SensorResponseBody>? HumiditySensors { get; set; }

    /// <summary>
    /// Position of the area on vehicle  Valid values: `back`, `front`, `middle`
    /// </summary>
    [JsonPropertyName("position")]
    public required VehicleSensorConfigurationAreaResponseBodyPosition Position { get; set; }

    [JsonPropertyName("temperatureSensors")]
    public IEnumerable<SensorResponseBody>? TemperatureSensors { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
