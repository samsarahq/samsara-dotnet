using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Auth;

public record GetTokenResponse
{
    [JsonPropertyName("access_token")]
    public required string AccessToken { get; set; }

    [JsonPropertyName("token_type")]
    public required string TokenType { get; set; }

    [JsonPropertyName("expires_in")]
    public required int ExpiresIn { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
