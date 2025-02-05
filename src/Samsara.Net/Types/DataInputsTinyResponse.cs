using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record DataInputsTinyResponse
{
    /// <summary>
    /// An array of data input objects. Each object contains the data input's name, ID, and other metadata.
    /// </summary>
    [JsonPropertyName("data")]
    public IEnumerable<DataInputTinyResponse>? Data { get; set; }

    [JsonPropertyName("pagination")]
    public PaginationResponse? Pagination { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
