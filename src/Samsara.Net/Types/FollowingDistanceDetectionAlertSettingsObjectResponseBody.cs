using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record FollowingDistanceDetectionAlertSettingsObjectResponseBody
{
    /// <summary>
    /// Duration of following distance at which to alert, measured in milliseconds.
    /// </summary>
    [JsonPropertyName("durationMs")]
    public long? DurationMs { get; set; }

    /// <summary>
    /// Indicates whether in-cab audio alerts for following distance are turned on.
    /// </summary>
    [JsonPropertyName("hasInCabAudioAlertsEnabled")]
    public bool? HasInCabAudioAlertsEnabled { get; set; }

    /// <summary>
    /// Indicates whether AI event detection for following distance is turned on.
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
