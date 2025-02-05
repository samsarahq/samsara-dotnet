using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record DvirsListResponse
{
    /// <summary>
    /// A list of DVIRs.
    /// </summary>
    [JsonPropertyName("data")]
    public IEnumerable<Dvir> Data { get; set; } = new List<Dvir>();

    [JsonPropertyName("pagination")]
    public required PaginationResponse Pagination { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
