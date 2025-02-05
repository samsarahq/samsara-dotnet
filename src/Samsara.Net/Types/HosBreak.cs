using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record HosBreak
{
    /// <summary>
    /// Time until the driver has a required break in milliseconds.
    /// </summary>
    [JsonPropertyName("timeUntilBreakDurationMs")]
    public double? TimeUntilBreakDurationMs { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
