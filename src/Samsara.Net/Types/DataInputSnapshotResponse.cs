using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record DataInputSnapshotResponse
{
    /// <summary>
    /// An array of data inputs' latest data points. Each object in the array represents a data input and its most recent data point.
    /// </summary>
    [JsonPropertyName("data")]
    public IEnumerable<DataInputSnapshot>? Data { get; set; }

    [JsonPropertyName("pagination")]
    public PaginationResponse? Pagination { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
