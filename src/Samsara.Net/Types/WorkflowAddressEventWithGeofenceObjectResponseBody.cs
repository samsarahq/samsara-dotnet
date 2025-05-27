using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// A minimal Address object representation used in AddressEventObject objects
/// </summary>
public record WorkflowAddressEventWithGeofenceObjectResponseBody
{
    /// <summary>
    /// A map of external ids
    /// </summary>
    [JsonPropertyName("externalIds")]
    public Dictionary<string, string>? ExternalIds { get; set; }

    /// <summary>
    /// The full street address for this address/geofence, as it might be recognized by Google Maps.
    /// </summary>
    [JsonPropertyName("formattedAddress")]
    public required string FormattedAddress { get; set; }

    [JsonPropertyName("geofence")]
    public WorkflowGeofenceResponseBody? Geofence { get; set; }

    /// <summary>
    /// Id of the address
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// Name of the address
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

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
