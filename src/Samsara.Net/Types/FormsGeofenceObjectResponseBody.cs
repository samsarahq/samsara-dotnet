using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Tracked or untracked (i.e. manually entered) geofence object.
/// </summary>
public record FormsGeofenceObjectResponseBody
{
    /// <summary>
    /// Address of the geofence. Included if 'entryType' is `tracked`.
    /// </summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    /// <summary>
    /// The type of entry for the geofence.  Valid values: `tracked`, `untracked`
    /// </summary>
    [JsonPropertyName("entryType")]
    public required FormsGeofenceObjectResponseBodyEntryType EntryType { get; set; }

    /// <summary>
    /// A map of external ids
    /// </summary>
    [JsonPropertyName("externalIds")]
    public Dictionary<string, string>? ExternalIds { get; set; }

    /// <summary>
    /// ID of the tracked geofence. Included if 'entryType' is `tracked`.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Name of an untracked (i.e. manually entered) geofence.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

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
