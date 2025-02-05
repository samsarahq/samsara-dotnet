using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record TachographDriverFilesResponse
{
    [JsonPropertyName("data")]
    public IEnumerable<TachographDriverFileListWrapper>? Data { get; set; }

    [JsonPropertyName("pagination")]
    public PaginationResponse? Pagination { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
