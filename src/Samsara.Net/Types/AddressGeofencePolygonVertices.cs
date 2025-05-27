using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record AddressGeofencePolygonVertices
{
    /// <summary>
    /// The latitude of a geofence vertex in decimal degrees.
    /// </summary>
    [JsonPropertyName("latitude")]
    public required double Latitude { get; set; }

    /// <summary>
    /// The longitude of a geofence vertex in decimal degrees.
    /// </summary>
    [JsonPropertyName("longitude")]
    public required double Longitude { get; set; }

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
