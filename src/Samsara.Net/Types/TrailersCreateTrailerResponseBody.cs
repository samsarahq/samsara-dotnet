using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record TrailersCreateTrailerResponseBody
{
    [JsonPropertyName("data")]
    public required TrailerWithAttributesResponseObjectResponseBody Data { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
