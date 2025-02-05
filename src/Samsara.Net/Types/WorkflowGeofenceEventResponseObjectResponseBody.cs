using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record WorkflowGeofenceEventResponseObjectResponseBody
{
    [JsonPropertyName("address")]
    public WorkflowAddressEventWithGeofenceObjectResponseBody? Address { get; set; }

    [JsonPropertyName("vehicle")]
    public VehicleWithGatewayTinyResponseResponseBody? Vehicle { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
