using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record DriverVehicleAssignmentsV2UpdateDriverVehicleAssignmentResponseBody
{
    [JsonPropertyName("data")]
    public required PatchDriverVehicleAssignmentsV2ResponseBodyResponseBody Data { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
