using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Auth.Tokens;

public record TokensCreateRequest
{
    /// <summary>
    /// The client secret of the application
    /// </summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    [JsonPropertyName("grant_type")]
    public string GrantType { get; set; } = "authorization_code";

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
