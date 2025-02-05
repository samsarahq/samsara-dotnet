using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record PatchAssetDataOutputsSingleResponseResponseBody
{
    /// <summary>
    /// If the request failed, this displays the error message.
    /// </summary>
    [JsonPropertyName("errorMessage")]
    public string? ErrorMessage { get; set; }

    /// <summary>
    /// The data output ID.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// The status code of the request. 200 indicates the request succeeded for this data output. 500 indicates an internal server error.
    /// </summary>
    [JsonPropertyName("statusCode")]
    public required long StatusCode { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
