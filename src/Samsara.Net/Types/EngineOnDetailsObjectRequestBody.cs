using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record EngineOnDetailsObjectRequestBody
{
    /// <summary>
    /// The number of milliseconds the trigger needs to stay active before alerting.
    /// </summary>
    [JsonPropertyName("minDurationMilliseconds")]
    public required long MinDurationMilliseconds { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
