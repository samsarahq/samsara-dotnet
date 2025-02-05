using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record LocationAndSpeedResponseResponseBody
{
    [JsonPropertyName("asset")]
    public required AssetResponseResponseBody Asset { get; set; }

    /// <summary>
    /// UTC timestamp in RFC 3339 format of the event.
    /// </summary>
    [JsonPropertyName("happenedAtTime")]
    public required string HappenedAtTime { get; set; }

    [JsonPropertyName("location")]
    public required LocationResponseResponseBody Location { get; set; }

    [JsonPropertyName("speed")]
    public SpeedResponseResponseBody? Speed { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
