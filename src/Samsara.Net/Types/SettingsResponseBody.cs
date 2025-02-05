using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record SettingsResponseBody
{
    /// <summary>
    /// The geofence setting. If this setting set to true, then underlying geofence addresses will be shown in reports instead of a geofence's name.
    /// </summary>
    [JsonPropertyName("showAddresses")]
    public IEnumerable<VertexResponseBody>? ShowAddresses { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
