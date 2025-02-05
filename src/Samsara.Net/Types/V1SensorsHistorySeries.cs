using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record V1SensorsHistorySeries
{
    /// <summary>
    /// Field to query.
    /// </summary>
    [JsonPropertyName("field")]
    public required V1SensorsHistorySeriesField Field { get; set; }

    /// <summary>
    /// V1Sensor ID to query.
    /// </summary>
    [JsonPropertyName("widgetId")]
    public required long WidgetId { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
