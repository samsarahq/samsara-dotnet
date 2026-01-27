using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Route feed object.
/// </summary>
[Serializable]
public record RouteFeedObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("changes")]
    public required RouteChangesResponseBody Changes { get; set; }

    /// <summary>
    /// The operation that was performed as part of this route update.  Valid values: `stop scheduled`, `stop en route`, `stop skipped`, `stop arrived`, `stop departed`, `stop ETA updated`, `stop arrival time updated`, `stop completion time updated`, `stop order changed`, `stop arrival prevented`
    /// </summary>
    [JsonPropertyName("operation")]
    public RouteFeedObjectResponseBodyOperation? Operation { get; set; }

    [JsonPropertyName("route")]
    public required BaseRouteResponseObjectResponseBody Route { get; set; }

    /// <summary>
    /// The source of this route update. Updates that are triggered by time or by the route being completed are 'automatic'.  Valid values: `automatic`, `driver`, `admin`
    /// </summary>
    [JsonPropertyName("source")]
    public required RouteFeedObjectResponseBodySource Source { get; set; }

    /// <summary>
    /// The timestamp of the route in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("time")]
    public required DateTime Time { get; set; }

    /// <summary>
    /// The type of route update. The route tracking updates occur as a route is completed and stops transition from one state to another. Currently only Route Tracking updates are supported, but this will change in the future when additional types are added.  Valid values: `route tracking`
    /// </summary>
    [JsonPropertyName("type")]
    public required RouteFeedObjectResponseBodyType Type { get; set; }

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
