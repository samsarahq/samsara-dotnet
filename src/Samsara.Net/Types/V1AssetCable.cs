using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record V1AssetCable
{
    /// <summary>
    /// Asset type
    /// </summary>
    [JsonPropertyName("assetType")]
    public string? AssetType { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
