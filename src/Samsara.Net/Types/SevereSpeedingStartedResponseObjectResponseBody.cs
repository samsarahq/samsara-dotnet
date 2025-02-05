using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record SevereSpeedingStartedResponseObjectResponseBody
{
    [JsonPropertyName("data")]
    public required SevereSpeedingStartedObjectResponseBody Data { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
