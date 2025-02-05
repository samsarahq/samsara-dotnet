using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record DriverAppSettingsResponseObjectResponseBody
{
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

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
