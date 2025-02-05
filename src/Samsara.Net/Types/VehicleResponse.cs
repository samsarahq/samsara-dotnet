using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record VehicleResponse
{
    [JsonPropertyName("data")]
    public required Vehicle Data { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
