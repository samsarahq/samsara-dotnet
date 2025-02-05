using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record VehicleSensorConfiguration
{
    [JsonPropertyName("areas")]
    public IEnumerable<VehicleSensorConfigurationArea>? Areas { get; set; }

    [JsonPropertyName("doors")]
    public IEnumerable<VehicleSensorConfigurationDoor>? Doors { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
