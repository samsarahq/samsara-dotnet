using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record MobileUsageDetectionAlertSettingsObjectResponseBody
{
    /// <summary>
    /// Indicates whether in-cab audio alerts for mobile usage are turned on.
    /// </summary>
    [JsonPropertyName("hasInCabAudioAlertsEnabled")]
    public bool? HasInCabAudioAlertsEnabled { get; set; }

    /// <summary>
    /// Indicates whether AI event detection for mobile usage is turned on.
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
