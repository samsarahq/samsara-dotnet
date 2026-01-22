using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Response object for create driver auth token
/// </summary>
[Serializable]
public record CreateDriverAuthTokenResponseResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Expiration time of the token in Unix milliseconds since epoch. Clients must redeem the token before this timestamp.
    /// </summary>
    [JsonPropertyName("expirationTime")]
    public required long ExpirationTime { get; set; }

    /// <summary>
    /// A one-time-use authentication token. Must be paired with the original code and driver identity in a separate request to exchange for a session.
    /// </summary>
    [JsonPropertyName("token")]
    public required string Token { get; set; }

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
