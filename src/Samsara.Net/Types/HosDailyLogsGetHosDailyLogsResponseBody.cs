using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record HosDailyLogsGetHosDailyLogsResponseBody
{
    /// <summary>
    /// List of drivers and their HOS daily logs data.
    /// </summary>
    [JsonPropertyName("data")]
    public IEnumerable<HosDailyLogsObjectResponseBody> Data { get; set; } =
        new List<HosDailyLogsObjectResponseBody>();

    [JsonPropertyName("pagination")]
    public required GoaPaginationResponseResponseBody Pagination { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
