using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record JobsCreateJobUnauthorizedErrorResponseBody
{
    /// <summary>
    /// Message of error
    /// </summary>
    [JsonPropertyName("message")]
    public required string Message { get; set; }

    /// <summary>
    /// The request ID; used when reaching out to support for issues with requests.
    /// </summary>
    [JsonPropertyName("requestId")]
    public required string RequestId { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
