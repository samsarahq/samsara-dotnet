using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Enables AI detection of distracted driving, surfaces events in Safety Inbox, and enables configurable alerts. By default, Distracted Driving will impact the drivers' safety score.
/// </summary>
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

    /// <summary>
    /// Additional properties received from the response, if any.
    /// </summary>
    /// <remarks>
    /// [EXPERIMENTAL] This API is experimental and may change in future releases.
    /// </remarks>
    [JsonExtensionData]
    public IDictionary<string, JsonElement> AdditionalProperties { get; internal set; } =
        new Dictionary<string, JsonElement>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
