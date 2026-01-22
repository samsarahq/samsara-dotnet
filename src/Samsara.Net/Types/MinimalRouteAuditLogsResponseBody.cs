using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// A single route. Only the fields that have changed are present in the response. All other fields, including the route id, will not be present in the response. For now, only routeStops are included since only Route Tracking updates are supported.
/// </summary>
[Serializable]
public record MinimalRouteAuditLogsResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The route stops in the route. Only stops that have been updated will be included in the response.
    /// </summary>
    [JsonPropertyName("stops")]
    public IEnumerable<MinimalRouteStopAuditLogsResponseBody>? Stops { get; set; }

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
