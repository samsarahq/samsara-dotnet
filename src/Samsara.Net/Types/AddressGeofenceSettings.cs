using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record AddressGeofenceSettings
{
    /// <summary>
    /// If this property is set to true, then underlying geofence addresses will be shown in reports instead of a geofence's name.
    /// </summary>
    [JsonPropertyName("showAddresses")]
    public bool? ShowAddresses { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
