using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[Serializable]
public record V1SensorHistoryResponseResults : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// List of datapoints, one for each requested (sensor, field) pair.
    /// </summary>
    [JsonPropertyName("series")]
    public IEnumerable<long>? Series { get; set; }

    /// <summary>
    /// Timestamp in UNIX milliseconds.
    /// </summary>
    [JsonPropertyName("timeMs")]
    public long? TimeMs { get; set; }

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
