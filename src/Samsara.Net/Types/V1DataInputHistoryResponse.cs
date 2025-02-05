using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record V1DataInputHistoryResponse
{
    /// <summary>
    /// The ID of this data input
    /// </summary>
    [JsonPropertyName("id")]
    public long? Id { get; set; }

    /// <summary>
    /// Name of this data input
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Data points from this data input
    /// </summary>
    [JsonPropertyName("points")]
    public IEnumerable<V1DataInputHistoryResponsePoints>? Points { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
