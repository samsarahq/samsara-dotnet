using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record DefectResponse
{
    [JsonPropertyName("data")]
    public Defect? Data { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
