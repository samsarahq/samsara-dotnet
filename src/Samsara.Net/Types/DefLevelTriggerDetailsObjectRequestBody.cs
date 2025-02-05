using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record DefLevelTriggerDetailsObjectRequestBody
{
    /// <summary>
    /// The DEF percentage threshold value.
    /// </summary>
    [JsonPropertyName("defLevelPercent")]
    public required long DefLevelPercent { get; set; }

    /// <summary>
    /// The number of milliseconds the trigger needs to stay active before alerting.
    /// </summary>
    [JsonPropertyName("minDurationMilliseconds")]
    public required long MinDurationMilliseconds { get; set; }

    /// <summary>
    /// How to evaluate the threshold.  Valid values: `GREATER`, `LESS`
    /// </summary>
    [JsonPropertyName("operation")]
    public required DefLevelTriggerDetailsObjectRequestBodyOperation Operation { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
