using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record V1AssetReeferResponseReeferStatsAlarms
{
    /// <summary>
    /// ID of the alarm
    /// </summary>
    [JsonPropertyName("alarmCode")]
    public long? AlarmCode { get; set; }

    /// <summary>
    /// Description of the alarm
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Recommended operator action
    /// </summary>
    [JsonPropertyName("operatorAction")]
    public string? OperatorAction { get; set; }

    /// <summary>
    /// Severity of the alarm: 1: OK to run, 2: Check as specified, 3: Take immediate action
    /// </summary>
    [JsonPropertyName("severity")]
    public long? Severity { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
