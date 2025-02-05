using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record AssetDataOutputsPatchAssetDataOutputsResponseBody
{
    /// <summary>
    /// List of responses for each data output from the original request.
    /// </summary>
    [JsonPropertyName("data")]
    public IEnumerable<PatchAssetDataOutputsSingleResponseResponseBody> Data { get; set; } =
        new List<PatchAssetDataOutputsSingleResponseResponseBody>();

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
