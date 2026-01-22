using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[Serializable]
public record DataInputSnapshotAllOf : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("fftSpectraPoint")]
    public FftSpectraDataPoint? FftSpectraPoint { get; set; }

    [JsonPropertyName("j1939D1StatusPoint")]
    public J1939D1StatusDataPoint? J1939D1StatusPoint { get; set; }

    [JsonPropertyName("locationPoint")]
    public LocationDataPoint? LocationPoint { get; set; }

    [JsonPropertyName("numberPoint")]
    public NumberDataPoint? NumberPoint { get; set; }

    [JsonPropertyName("stringPoint")]
    public StringDataPoint? StringPoint { get; set; }

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
