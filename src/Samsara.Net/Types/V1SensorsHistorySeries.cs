using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// V1Sensor ID and field to query.
/// </summary>
[Serializable]
public record V1SensorsHistorySeries : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Field to query.
    /// </summary>
    [JsonPropertyName("field")]
    public required V1SensorsHistorySeriesField Field { get; set; }

    /// <summary>
    /// V1Sensor ID to query.
    /// </summary>
    [JsonPropertyName("widgetId")]
    public required long WidgetId { get; set; }

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
