using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record VehicleSensorConfigurationDoor
{
    /// <summary>
    /// Position of the door monitor on the vehicle
    /// </summary>
    [JsonPropertyName("position")]
    public VehicleSensorConfigurationDoorPosition? Position { get; set; }

    [JsonPropertyName("sensor")]
    public Sensor? Sensor { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
