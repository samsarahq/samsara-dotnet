using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record JobsPatchJobResponseBody
{
    [JsonPropertyName("data")]
    public required JobResponseObjectResponseBody Data { get; set; }

    /// <summary>
    /// The job id of the failed request
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// The uuid of the failed request
    /// </summary>
    [JsonPropertyName("uuid")]
    public string? Uuid { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
