using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record ForwardCollisionDetectionAlertSettingsObjectResponseBody
{
    /// <summary>
    /// Indicates whether in-cab audio alerts for forward collision are turned on.
    /// </summary>
    [JsonPropertyName("hasInCabAudioAlertsEnabled")]
    public bool? HasInCabAudioAlertsEnabled { get; set; }

    /// <summary>
    /// Indicates whether AI event detection for forward collision is turned on.
    /// </summary>
    [JsonPropertyName("isEnabled")]
    public bool? IsEnabled { get; set; }

    /// <summary>
    /// Ranges from near forward collision (results in fewer events) to far forward collision (results in more events).  Valid values: `near`, `medium`, `far`
    /// </summary>
    [JsonPropertyName("sensitivity")]
    public ForwardCollisionDetectionAlertSettingsObjectResponseBodySensitivity? Sensitivity { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
