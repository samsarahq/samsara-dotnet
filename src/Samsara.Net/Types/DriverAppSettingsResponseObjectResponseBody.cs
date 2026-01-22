using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// The configuration settings for the Samsara Driver App. Can be set or updated through the Samsara Settings page or the API at any time.
/// </summary>
[Serializable]
public record DriverAppSettingsResponseObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Login user name for the fleet driver app
    /// </summary>
    [JsonPropertyName("driverFleetId")]
    public string? DriverFleetId { get; set; }

    /// <summary>
    /// Driver gamification feature. Enabling this will turn on the feature for all drivers using the mobile app. Drivers can be configured into peer groups within the Drivers Page. Unconfigured drivers will be grouped on an organization level.
    /// </summary>
    [JsonPropertyName("gamification")]
    public bool? Gamification { get; set; }

    [JsonPropertyName("gamificationConfig")]
    public DriverAppSettingsGamificationConfigTinyObjectResponseBody? GamificationConfig { get; set; }

    /// <summary>
    /// Allow drivers to search for vehicles outside of their selection tag when connected to the internet.
    /// </summary>
    [JsonPropertyName("orgVehicleSearch")]
    public bool? OrgVehicleSearch { get; set; }

    /// <summary>
    /// Allow drivers to see and select trailers in the Samsara Driver app.
    /// </summary>
    [JsonPropertyName("trailerSelection")]
    public bool? TrailerSelection { get; set; }

    [JsonPropertyName("trailerSelectionConfig")]
    public DriverAppSettingsTrailerSelectionConfigTinyObjectResponseBody? TrailerSelectionConfig { get; set; }

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
