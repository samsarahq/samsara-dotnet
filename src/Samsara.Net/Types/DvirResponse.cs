using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record DvirResponse
{
    [JsonPropertyName("data")]
    public Dvir? Data { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
