using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record TimeRangeObjectResponseBody
{
    /// <summary>
    /// Which days this timezone applies to.
    /// </summary>
    [JsonPropertyName("daysOfWeek")]
    public IEnumerable<TimeRangeObjectResponseBodyDaysOfWeekItem> DaysOfWeek { get; set; } =
        new List<TimeRangeObjectResponseBodyDaysOfWeekItem>();

    /// <summary>
    /// The time of day at which the time range starts. In 24 hour kitchen clock format.
    /// </summary>
    [JsonPropertyName("endTime")]
    public required string EndTime { get; set; }

    /// <summary>
    /// The time of day at which the time range starts. In 24 hour kitchen clock format.
    /// </summary>
    [JsonPropertyName("startTime")]
    public required string StartTime { get; set; }

    /// <summary>
    /// The timezone of the time range uses [IANA timezone database](https://www.iana.org/time-zones) keys (e.g. `America/Los_Angeles`, `America/New_York`, `Europe/London`, etc.). You can find a mapping of common timezone formats to IANA timezone keys [here](https://unicode.org/cldr/charts/latest/supplemental/zone_tzid.html).
    /// </summary>
    [JsonPropertyName("timezone")]
    public required string Timezone { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
