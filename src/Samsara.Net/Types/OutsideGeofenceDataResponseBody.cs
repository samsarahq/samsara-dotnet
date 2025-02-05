using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record OutsideGeofenceDataResponseBody
{
    [JsonPropertyName("driver")]
    public AlertObjectDriverResponseBody? Driver { get; set; }

    [JsonPropertyName("trailer")]
    public AlertObjectTrailerResponseBody? Trailer { get; set; }

    [JsonPropertyName("vehicle")]
    public AlertObjectVehicleResponseBody? Vehicle { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
