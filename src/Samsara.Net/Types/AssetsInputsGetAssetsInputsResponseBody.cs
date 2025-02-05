using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record AssetsInputsGetAssetsInputsResponseBody
{
    /// <summary>
    /// Array of assets inputs objects.
    /// </summary>
    [JsonPropertyName("data")]
    public IEnumerable<AssetsInputsResponseResponseBody> Data { get; set; } =
        new List<AssetsInputsResponseResponseBody>();

    [JsonPropertyName("pagination")]
    public required GoaPaginationResponseResponseBody Pagination { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
