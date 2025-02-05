using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record FormsAssetValueObjectResponseBody
{
    [JsonPropertyName("asset")]
    public required FormsAssetObjectResponseBody Asset { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
