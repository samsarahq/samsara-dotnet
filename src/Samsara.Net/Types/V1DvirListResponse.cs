using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record V1DvirListResponse
{
    [JsonPropertyName("dvirs")]
    public IEnumerable<V1DvirBase>? Dvirs { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
