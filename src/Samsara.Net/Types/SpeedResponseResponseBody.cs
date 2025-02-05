using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record SpeedResponseResponseBody
{
    /// <summary>
    /// Speed of asset based on ECU data.
    /// </summary>
    [JsonPropertyName("ecuSpeedMetersPerSecond")]
    public double? EcuSpeedMetersPerSecond { get; set; }

    /// <summary>
    /// Speed of asset based on GPS data.
    /// </summary>
    [JsonPropertyName("gpsSpeedMetersPerSecond")]
    public double? GpsSpeedMetersPerSecond { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
