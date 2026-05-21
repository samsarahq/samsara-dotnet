using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Additional service time at a hub location.
/// </summary>
[Serializable]
public record HubLocationServiceTimeResponseResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Whole minutes of additional service time.
    /// </summary>
    [JsonPropertyName("additionalTimeMinutes")]
    public required long AdditionalTimeMinutes { get; set; }

    /// <summary>
    /// Whether additional service time is enabled.
    /// </summary>
    [JsonPropertyName("isEnabled")]
    public required bool IsEnabled { get; set; }

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
