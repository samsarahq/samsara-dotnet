using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record AmbientTemperatureDetailsObjectResponseBody
{
    /// <summary>
    /// Whether the cargo is full.
    /// </summary>
    [JsonPropertyName("cargoIsFull")]
    public bool? CargoIsFull { get; set; }

    /// <summary>
    /// Whether the doors are closed.
    /// </summary>
    [JsonPropertyName("doorsAreClosed")]
    public bool? DoorsAreClosed { get; set; }

    /// <summary>
    /// The number of milliseconds the trigger needs to stay active before alerting.
    /// </summary>
    [JsonPropertyName("minDurationMilliseconds")]
    public required long MinDurationMilliseconds { get; set; }

    /// <summary>
    /// How to evaluate the threshold.  Valid values: `GREATER`, `INSIDE_RANGE`, `LESS`, `OUTSIDE_RANGE`
    /// </summary>
    [JsonPropertyName("operation")]
    public required AmbientTemperatureDetailsObjectResponseBodyOperation Operation { get; set; }

    /// <summary>
    /// The temperature in Celcius threshold value.
    /// </summary>
    [JsonPropertyName("temperatureCelcius")]
    public required long TemperatureCelcius { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
