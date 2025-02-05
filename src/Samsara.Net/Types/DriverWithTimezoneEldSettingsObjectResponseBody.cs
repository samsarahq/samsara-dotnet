using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record DriverWithTimezoneEldSettingsObjectResponseBody
{
    [JsonPropertyName("eldSettings")]
    public EldSettingsObjectResponseBody? EldSettings { get; set; }

    /// <summary>
    /// A map of external ids
    /// </summary>
    [JsonPropertyName("externalIds")]
    public Dictionary<string, string>? ExternalIds { get; set; }

    /// <summary>
    /// ID of the driver
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// Name of the driver
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Home terminal timezone, in order to indicate what time zone should be used to calculate the ELD logs. Driver timezones use [IANA timezone database](https://www.iana.org/time-zones) keys (e.g. `America/Los_Angeles`, `America/New_York`, `Europe/London`, etc.). You can find a mapping of common timezone formats to IANA timezone keys [here](https://unicode.org/cldr/charts/latest/supplemental/zone_tzid.html).
    /// </summary>
    [JsonPropertyName("timezone")]
    public string? Timezone { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
