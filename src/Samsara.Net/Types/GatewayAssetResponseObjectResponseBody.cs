using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record GatewayAssetResponseObjectResponseBody
{
    /// <summary>
    /// A map of external ids
    /// </summary>
    [JsonPropertyName("externalIds")]
    public Dictionary<string, string>? ExternalIds { get; set; }

    /// <summary>
    /// The unique Samsara ID of the asset where the gateway is installed. This is automatically generated when the asset is created and cannot be changed. Use this ID on PATCH vehicle, equipment, or trailer endpoints to update the asset
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
