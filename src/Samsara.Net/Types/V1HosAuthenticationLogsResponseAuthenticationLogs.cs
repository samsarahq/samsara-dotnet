using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[Serializable]
public record V1HosAuthenticationLogsResponseAuthenticationLogs : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The log type - one of 'signin' or 'signout'
    /// </summary>
    [JsonPropertyName("actionType")]
    public string? ActionType { get; set; }

    /// <summary>
    /// DEPRECATED: THIS FIELD MAY NOT BE POPULATED
    /// </summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    /// <summary>
    /// DEPRECATED: THIS FIELD MAY NOT BE POPULATED
    /// </summary>
    [JsonPropertyName("addressName")]
    public string? AddressName { get; set; }

    /// <summary>
    /// DEPRECATED: THIS FIELD MAY NOT BE POPULATED
    /// </summary>
    [JsonPropertyName("city")]
    public string? City { get; set; }

    /// <summary>
    /// The time at which the event was recorded in UNIX milliseconds.
    /// </summary>
    [JsonPropertyName("happenedAtMs")]
    public long? HappenedAtMs { get; set; }

    /// <summary>
    /// DEPRECATED: THIS FIELD MAY NOT BE POPULATED
    /// </summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

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
