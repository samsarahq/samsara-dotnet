using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Enables AI detection of distracted driving, surfaces events in Safety Inbox, and enables configurable alerts. By default, Distracted Driving will impact the drivers' safety score.
/// </summary>
[Serializable]
public record DistractedDrivingDetectionAlertSettingsObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("inattentiveDrivingDetectionAlerts")]
    public InattentiveDrivingDetectionAlertSettingsObjectResponseBody? InattentiveDrivingDetectionAlerts { get; set; }

    /// <summary>
    /// Indicates whether AI event detection for distracted driving behaviors is turned on.
    /// </summary>
    [JsonPropertyName("isEnabled")]
    public bool? IsEnabled { get; set; }

    [JsonPropertyName("mobileUsageDetectionAlerts")]
    public MobileUsageDetectionAlertSettingsObjectResponseBody? MobileUsageDetectionAlerts { get; set; }

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
