using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record GatewayDisconnectedDetailsObjectRequestBody
{
    /// <summary>
    /// The number of milliseconds the trigger needs to stay active before alerting. Can only be either 900000 (15 minutes) or 3600000 (60 min).
    /// </summary>
    [JsonPropertyName("minDurationMilliseconds")]
    public required long MinDurationMilliseconds { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
