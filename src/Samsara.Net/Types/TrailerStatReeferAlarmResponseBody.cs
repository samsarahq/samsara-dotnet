using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record TrailerStatReeferAlarmResponseBody
{
    /// <summary>
    /// The ID of the alarm.
    /// </summary>
    [JsonPropertyName("alarmCode")]
    public required string AlarmCode { get; set; }

    /// <summary>
    /// The description of the alarm.
    /// </summary>
    [JsonPropertyName("description")]
    public required string Description { get; set; }

    /// <summary>
    /// The recommended operator action.
    /// </summary>
    [JsonPropertyName("operatorAction")]
    public required string OperatorAction { get; set; }

    /// <summary>
    /// The severity of the alarm. `1`: Ok to run, `2`: Check as specified, `3`: Take immediate action.
    /// </summary>
    [JsonPropertyName("severity")]
    public required long Severity { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
