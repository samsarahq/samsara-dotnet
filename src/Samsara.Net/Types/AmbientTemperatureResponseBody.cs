using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record AmbientTemperatureResponseBody
{
    [JsonPropertyName("sensor")]
    public AlertObjectSensorResponseBody? Sensor { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
