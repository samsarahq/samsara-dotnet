using System.Text.Json.Serialization;
using Samsara.Net;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

public record JobsCreateJobRequestBody
{
    [JsonPropertyName("job")]
    public required PostJobObjectRequestBody Job { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
