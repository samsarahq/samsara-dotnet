using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record DriverResponse
{
    [JsonPropertyName("data")]
    public Driver? Data { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
