using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Auth;

public record AuthGetTokenRequest
{
    /// <summary>
    /// The client ID of the application
    /// </summary>
    [JsonPropertyName("client_id")]
    public required string ClientId { get; set; }

    /// <summary>
    /// The client secret of the application
    /// </summary>
    [JsonPropertyName("client_secret")]
    public required string ClientSecret { get; set; }

    /// <summary>
    /// The API identifier
    /// </summary>
    [JsonPropertyName("audience")]
    public string Audience { get; set; } = "https://api.samsara.com";

    [JsonPropertyName("grant_type")]
    public string GrantType { get; set; } = "authorization_code";

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
