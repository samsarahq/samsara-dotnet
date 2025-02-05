using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record DistractedDrivingDetectionAlertSettingsObjectResponseBody
{
    [JsonPropertyName("inattentiveDrivingDetectionAlerts")]
    public InattentiveDrivingDetectionAlertSettingsObjectResponseBody? InattentiveDrivingDetectionAlerts { get; set; }

    /// <summary>
    /// Indicates whether AI event detection for distracted driving behaviors is turned on.
    /// </summary>
    [JsonPropertyName("isEnabled")]
    public bool? IsEnabled { get; set; }

    [JsonPropertyName("mobileUsageDetectionAlerts")]
    public MobileUsageDetectionAlertSettingsObjectResponseBody? MobileUsageDetectionAlerts { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
