using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record TrailersGetTrailerResponseBody
{
    [JsonPropertyName("data")]
    public required TrailerWithAttributesResponseObjectResponseBody Data { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
