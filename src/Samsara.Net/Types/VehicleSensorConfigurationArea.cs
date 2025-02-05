using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record VehicleSensorConfigurationArea
{
    /// <summary>
    /// Cargo sensors configured in this position of the vehicle
    /// </summary>
    [JsonPropertyName("cargoSensors")]
    public IEnumerable<Sensor>? CargoSensors { get; set; }

    /// <summary>
    /// Humidity sensors configured in this position of the vehicle
    /// </summary>
    [JsonPropertyName("humiditySensors")]
    public IEnumerable<Sensor>? HumiditySensors { get; set; }

    /// <summary>
    /// Position of the area on vehicle
    /// </summary>
    [JsonPropertyName("position")]
    public VehicleSensorConfigurationAreaPosition? Position { get; set; }

    /// <summary>
    /// Temperature sensors configured in this position of the vehicle
    /// </summary>
    [JsonPropertyName("temperatureSensors")]
    public IEnumerable<Sensor>? TemperatureSensors { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
