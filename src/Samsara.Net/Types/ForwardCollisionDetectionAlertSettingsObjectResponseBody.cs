using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Enables AI detection of near forward collisions, surfaces events in Safety Inbox, and enables configurable alerts. While the feature is in beta, it is only enabled during daytime driving hours. In-cab alerts are recommended for testing use only.
/// </summary>
[Serializable]
public record ForwardCollisionDetectionAlertSettingsObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

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
