using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record V1DriverDailyLogResponse
{
    [JsonPropertyName("days")]
    public IEnumerable<V1DriverDailyLogResponseDays>? Days { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
