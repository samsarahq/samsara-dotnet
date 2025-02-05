using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record SpeedTriggerDetailsObjectRequestBody
{
    /// <summary>
    /// The number of milliseconds the trigger needs to stay active before alerting.
    /// </summary>
    [JsonPropertyName("minDurationMilliseconds")]
    public required long MinDurationMilliseconds { get; set; }

    /// <summary>
    /// How to evaluate the threshold.  Valid values: `GREATER`, `LESS`
    /// </summary>
    [JsonPropertyName("operation")]
    public required SpeedTriggerDetailsObjectRequestBodyOperation Operation { get; set; }

    /// <summary>
    /// The speed threshold value.
    /// </summary>
    [JsonPropertyName("speedKilometersPerHour")]
    public required long SpeedKilometersPerHour { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
