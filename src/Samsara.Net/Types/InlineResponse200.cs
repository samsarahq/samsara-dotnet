using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record InlineResponse200
{
    [JsonPropertyName("data")]
    public AssetResponse? Data { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
