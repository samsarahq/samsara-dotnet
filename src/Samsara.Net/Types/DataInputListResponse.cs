using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record DataInputListResponse
{
    /// <summary>
    /// An array of data input data points. Each object in the array represents a data input and will contain its associated data points.
    /// </summary>
    [JsonPropertyName("data")]
    public IEnumerable<DataInputResponse>? Data { get; set; }

    [JsonPropertyName("pagination")]
    public PaginationResponse? Pagination { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
