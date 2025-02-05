using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record DriverAppSettingsGamificationConfigTinyObjectResponseBody
{
    /// <summary>
    /// Hide the names of other drivers when viewing the driver leaderboard in the mobile app.
    /// </summary>
    [JsonPropertyName("anonymizeDriverNames")]
    public bool? AnonymizeDriverNames { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
