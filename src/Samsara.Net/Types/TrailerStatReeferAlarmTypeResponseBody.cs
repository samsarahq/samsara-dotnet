using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record TrailerStatReeferAlarmTypeResponseBody
{
    /// <summary>
    /// The alarms reported by the reefer.
    /// </summary>
    [JsonPropertyName("alarms")]
    public IEnumerable<TrailerStatReeferAlarmResponseBody> Alarms { get; set; } =
        new List<TrailerStatReeferAlarmResponseBody>();

    /// <summary>
    /// UTC timestamp in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("time")]
    public required string Time { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
