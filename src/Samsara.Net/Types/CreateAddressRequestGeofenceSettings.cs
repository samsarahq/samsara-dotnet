using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Information about a geofence's settings.
/// </summary>
public record CreateAddressRequestGeofenceSettings
{
    /// <summary>
    /// If this property is set to true, then underlying geofence addresses will be shown in reports instead of a geofence's name.
    /// </summary>
    [JsonPropertyName("showAddresses")]
    public bool? ShowAddresses { get; set; }

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
