using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Auth.Tokens;

public record TokensRevokeRequest
{
    /// <summary>
    /// The token to revoke
    /// </summary>
    [JsonPropertyName("token")]
    public required string Token { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
