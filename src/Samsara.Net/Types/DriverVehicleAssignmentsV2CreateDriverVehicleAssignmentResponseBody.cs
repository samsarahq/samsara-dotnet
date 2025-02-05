using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record DriverVehicleAssignmentsV2CreateDriverVehicleAssignmentResponseBody
{
    [JsonPropertyName("data")]
    public required PostDriverVehicleAssignmentsV2ResponseBodyResponseBody Data { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
