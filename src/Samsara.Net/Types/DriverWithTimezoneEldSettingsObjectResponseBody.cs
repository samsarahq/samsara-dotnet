using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// The driver the log applies to.
/// </summary>
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
