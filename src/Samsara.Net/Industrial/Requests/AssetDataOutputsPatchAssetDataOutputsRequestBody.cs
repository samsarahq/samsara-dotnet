using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Industrial;

[Serializable]
public record AssetDataOutputsPatchAssetDataOutputsRequestBody
{
    /// <summary>
    /// A map of data output IDs to values. All data outputs must belong to the same asset. Only the specified IDs will be written to.
    /// </summary>
    [JsonPropertyName("values")]
    public Dictionary<string, object?> Values { get; set; } = new Dictionary<string, object?>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
