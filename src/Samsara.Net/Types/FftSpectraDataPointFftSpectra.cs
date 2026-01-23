using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// FFT spectrum data
/// </summary>
[Serializable]
public record FftSpectraDataPointFftSpectra : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Frequencies
    /// </summary>
    [JsonPropertyName("frequencies")]
    public IEnumerable<double>? Frequencies { get; set; }

    /// <summary>
    /// X-axis data
    /// </summary>
    [JsonPropertyName("x")]
    public IEnumerable<double>? X { get; set; }

    /// <summary>
    /// Y-axis data
    /// </summary>
    [JsonPropertyName("y")]
    public IEnumerable<double>? Y { get; set; }

    /// <summary>
    /// Z-axis data
    /// </summary>
    [JsonPropertyName("z")]
    public IEnumerable<double>? Z { get; set; }

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
