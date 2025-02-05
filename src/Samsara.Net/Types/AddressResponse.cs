using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record AddressResponse
{
    [JsonPropertyName("data")]
    public required Address Data { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
