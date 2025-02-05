using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record FuelLevelTriggerDetailsObjectResponseBody
{
    /// <summary>
    /// The fuel level percentage threshold value.
    /// </summary>
    [JsonPropertyName("fuelLevelPercent")]
    public required long FuelLevelPercent { get; set; }

    /// <summary>
    /// The number of milliseconds the trigger needs to stay active before alerting.
    /// </summary>
    [JsonPropertyName("minDurationMilliseconds")]
    public required long MinDurationMilliseconds { get; set; }

    /// <summary>
    /// How to evaluate the threshold.  Valid values: `LESS`
    /// </summary>
    [JsonPropertyName("operation")]
    public required string Operation { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
