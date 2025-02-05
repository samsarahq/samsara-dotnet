using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record CreateAddressRequestGeofence
{
    [JsonPropertyName("circle")]
    public AddressGeofenceCircle? Circle { get; set; }

    [JsonPropertyName("polygon")]
    public AddressGeofencePolygon? Polygon { get; set; }

    [JsonPropertyName("settings")]
    public CreateAddressRequestGeofenceSettings? Settings { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
