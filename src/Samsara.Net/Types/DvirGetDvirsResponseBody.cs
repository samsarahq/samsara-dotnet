using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record DvirGetDvirsResponseBody
{
    [JsonPropertyName("data")]
    public IEnumerable<DvirStreamResponseDataResponseBody> Data { get; set; } =
        new List<DvirStreamResponseDataResponseBody>();

    [JsonPropertyName("pagination")]
    public required GoaPaginationResponseResponseBody Pagination { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
