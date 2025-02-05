using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record EquipmentGatewayJ1939EngineSeconds
{
    [JsonPropertyName("time")]
    public required string Time { get; set; }

    /// <summary>
    /// An approximation of the number of seconds the engine has been running since it was new, based on the amount of time the AG26 device is receiving power and an offset provided manually through the Samsara cloud dashboard.
    /// </summary>
    [JsonPropertyName("value")]
    public required int Value { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
