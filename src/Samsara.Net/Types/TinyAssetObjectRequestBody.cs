using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record TinyAssetObjectRequestBody
{
    /// <summary>
    /// ID of the asset.
    /// </summary>
    [JsonPropertyName("assetId")]
    public required string AssetId { get; set; }

    /// <summary>
    /// The operational context in which the asset interacts with the Samsara system. Examples: Vehicle (eg: truck, bus...), Trailer (eg: dry van, reefer, flatbed...), Powered Equipment (eg: dozer, crane...), Unpowered Equipment (eg: container, dumpster...), or Uncategorized.  Valid values: `uncategorized`, `trailer`, `equipment`, `unpowered`, `vehicle`
    /// </summary>
    [JsonPropertyName("assetType")]
    public required TinyAssetObjectRequestBodyAssetType AssetType { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
