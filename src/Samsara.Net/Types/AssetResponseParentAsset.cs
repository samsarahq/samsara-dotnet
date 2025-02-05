using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record AssetResponseParentAsset
{
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
