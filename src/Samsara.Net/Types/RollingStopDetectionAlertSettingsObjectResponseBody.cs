using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record RollingStopDetectionAlertSettingsObjectResponseBody
{
    /// <summary>
    /// Indicates whether AI event detection for rolling stops is turned on.
    /// </summary>
    [JsonPropertyName("isEnabled")]
    public bool? IsEnabled { get; set; }

    /// <summary>
    /// Alert when speed is over this many miles per hour.
    /// </summary>
    [JsonPropertyName("speedingThresholdMph")]
    public double? SpeedingThresholdMph { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
