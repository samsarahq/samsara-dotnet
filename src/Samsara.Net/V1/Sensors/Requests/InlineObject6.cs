using System.Text.Json.Serialization;
using Samsara.Net;
using Samsara.Net.Core;

namespace Samsara.Net.V1.Sensors;

public record InlineObject6
{
    /// <summary>
    /// End of the time range, specified in milliseconds UNIX time.
    /// </summary>
    [JsonPropertyName("endMs")]
    public required int EndMs { get; set; }

    [JsonPropertyName("fillMissing")]
    public InlineObject6FillMissing? FillMissing { get; set; }

    [JsonPropertyName("series")]
    public IEnumerable<V1SensorsHistorySeries> Series { get; set; } =
        new List<V1SensorsHistorySeries>();

    /// <summary>
    /// Beginning of the time range, specified in milliseconds UNIX time.
    /// </summary>
    [JsonPropertyName("startMs")]
    public required int StartMs { get; set; }

    /// <summary>
    /// Time resolution for which data should be returned, in milliseconds. Specifying 3600000 will return data at hour intervals.
    /// </summary>
    [JsonPropertyName("stepMs")]
    public required int StepMs { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
