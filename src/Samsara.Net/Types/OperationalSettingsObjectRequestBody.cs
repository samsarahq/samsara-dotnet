using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record OperationalSettingsObjectRequestBody
{
    /// <summary>
    /// The type of time ranges.  Valid values: `activeBetween`, `inactiveBetween`
    /// </summary>
    [JsonPropertyName("timeRangeType")]
    public required OperationalSettingsObjectRequestBodyTimeRangeType TimeRangeType { get; set; }

    /// <summary>
    /// The time ranges this alert applies to.
    /// </summary>
    [JsonPropertyName("timeRanges")]
    public IEnumerable<TimeRangeObjectRequestBody> TimeRanges { get; set; } =
        new List<TimeRangeObjectRequestBody>();

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
