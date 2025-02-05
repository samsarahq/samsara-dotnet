using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record OperationalSettingsObjectResponseBody
{
    /// <summary>
    /// The type of time ranges.  Valid values: `activeBetween`, `inactiveBetween`
    /// </summary>
    [JsonPropertyName("timeRangeType")]
    public required OperationalSettingsObjectResponseBodyTimeRangeType TimeRangeType { get; set; }

    /// <summary>
    /// The time ranges this alert applies to.
    /// </summary>
    [JsonPropertyName("timeRanges")]
    public IEnumerable<TimeRangeObjectResponseBody> TimeRanges { get; set; } =
        new List<TimeRangeObjectResponseBody>();

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
