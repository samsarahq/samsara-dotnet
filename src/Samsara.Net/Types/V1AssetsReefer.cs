using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record V1AssetsReefer
{
    /// <summary>
    /// Asset type
    /// </summary>
    [JsonPropertyName("assetType")]
    public string? AssetType { get; set; }

    /// <summary>
    /// Asset ID
    /// </summary>
    [JsonPropertyName("id")]
    public int? Id { get; set; }

    /// <summary>
    /// Asset name
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("reeferStats")]
    public V1AssetsReeferReeferStats? ReeferStats { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
