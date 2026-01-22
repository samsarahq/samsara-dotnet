using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Enum value to alert on if reading is discrete, either enum or continuous threshold may be set.
/// </summary>
[Serializable]
public record ReadingTriggerEnumValueObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The numeric representation of the enum value.
    /// </summary>
    [JsonPropertyName("number")]
    public long? Number { get; set; }

    /// <summary>
    /// The symbol representation of the enum value.
    /// </summary>
    [JsonPropertyName("symbol")]
    public string? Symbol { get; set; }

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
