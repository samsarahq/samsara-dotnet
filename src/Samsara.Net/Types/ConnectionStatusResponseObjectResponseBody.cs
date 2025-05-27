using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// An objecting containing information about the connectivity status of the gateway
/// </summary>
public record ConnectionStatusResponseObjectResponseBody
{
    /// <summary>
    /// The most recent health status of the gateway.  Valid values: `Status Not Set`, `Connected`, `Not Installed`, `Power Source Off - Active Vehicle`, `Power Source Off - Inactive Vehicle`, `Weak Cellular Signal`, `Requires Investigation`, `Requires Charge`, `Unsupported Product`, `Low Battery. Replace Device.`, `Low Vehicle Battery`, `Unplugged`, `Low Charging State`, `Vehicle Off`, `Weak GPS Signal`, `Low Gateway Battery`, `Low Gateway Battery (AG24)`, `Low Gateway Battery (AG45)`, `Low Gateway Battery (AG26)`, `Low Gateway Battery (AG46)`, `Low Gateway Battery (AG46-P)`, `Temporarily Offline`, `Prolonged Offline`, `Recently Offline`, `Replacement Required`, `Status Unknown`
    /// </summary>
    [JsonPropertyName("healthStatus")]
    public ConnectionStatusResponseObjectResponseBodyHealthStatus? HealthStatus { get; set; }

    /// <summary>
    /// The last time the gateway was connected in RFC 3339 format. Millisecond precision and timezones are supported. (Examples: 2019-06-13T19:08:25Z, 2019-06-13T19:08:25.455Z, OR 2015-09-15T14:00:12-04:00).
    /// </summary>
    [JsonPropertyName("lastConnected")]
    public string? LastConnected { get; set; }

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
