using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Customer-defined order metadata.
/// </summary>
[Serializable]
public record FleetOrderCustomerPropertyObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Customer-defined property key.
    /// </summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Customer-defined property value.
    /// </summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }

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
