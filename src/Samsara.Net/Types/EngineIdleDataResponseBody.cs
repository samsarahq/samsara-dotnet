using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record EngineIdleDataResponseBody
{
    [JsonPropertyName("driver")]
    public AlertObjectDriverResponseBody? Driver { get; set; }

    [JsonPropertyName("vehicle")]
    public AlertObjectVehicleResponseBody? Vehicle { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
