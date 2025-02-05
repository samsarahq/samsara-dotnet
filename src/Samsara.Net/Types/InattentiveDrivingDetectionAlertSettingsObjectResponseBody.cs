using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record InattentiveDrivingDetectionAlertSettingsObjectResponseBody
{
    /// <summary>
    /// Indicates whether in-cab audio alerts for inattentive driving are turned on.
    /// </summary>
    [JsonPropertyName("hasInCabAudioAlertsEnabled")]
    public bool? HasInCabAudioAlertsEnabled { get; set; }

    /// <summary>
    /// Indicates whether AI event detection for inattentive driving is turned on.
    /// </summary>
    [JsonPropertyName("isEnabled")]
    public bool? IsEnabled { get; set; }

    /// <summary>
    /// Severity of inattentive driving events. Options include low (alerts for all events), medium (alerts for medium and high severity events), and high (alerts for high severity events only).  Valid values: `low`, `medium`, `high`
    /// </summary>
    [JsonPropertyName("severity")]
    public InattentiveDrivingDetectionAlertSettingsObjectResponseBodySeverity? Severity { get; set; }

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
