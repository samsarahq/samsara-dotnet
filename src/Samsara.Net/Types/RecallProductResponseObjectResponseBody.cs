using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Vehicle make, model, year, and affected production dates.
/// </summary>
[Serializable]
public record RecallProductResponseObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Make named by the recall.
    /// </summary>
    [JsonPropertyName("make")]
    public required string Make { get; set; }

    /// <summary>
    /// End of the affected production window, in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("manufactureEndTime")]
    public DateTime? ManufactureEndTime { get; set; }

    /// <summary>
    /// Start of the affected production window, in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("manufactureStartTime")]
    public DateTime? ManufactureStartTime { get; set; }

    /// <summary>
    /// Model named by the recall.
    /// </summary>
    [JsonPropertyName("model")]
    public required string Model { get; set; }

    /// <summary>
    /// Model year named by the recall.
    /// </summary>
    [JsonPropertyName("year")]
    public required long Year { get; set; }

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
