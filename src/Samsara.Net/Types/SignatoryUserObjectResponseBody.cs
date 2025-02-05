using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record SignatoryUserObjectResponseBody
{
    /// <summary>
    /// ID of the user.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
