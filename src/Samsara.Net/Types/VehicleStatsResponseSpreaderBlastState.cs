using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record VehicleStatsResponseSpreaderBlastState
{
    /// <summary>
    /// UTC timestamp in RFC 3339 format. Example: `2020-01-27T07:06:25Z`.
    /// </summary>
    [JsonPropertyName("time")]
    public required string Time { get; set; }

    /// <summary>
    /// Whether vehicle is actively spreading material in ‘blast mode’.
    /// </summary>
    [JsonPropertyName("value")]
    public required VehicleStatsResponseSpreaderBlastStateValue Value { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
