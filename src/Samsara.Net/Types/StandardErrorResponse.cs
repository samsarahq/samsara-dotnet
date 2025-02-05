using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record StandardErrorResponse
{
    /// <summary>
    /// The message of the error.
    /// </summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>
    /// The ID of the request.
    /// </summary>
    [JsonPropertyName("requestId")]
    public string? RequestId { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
