using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[Serializable]
public record DataInputResponseAllOf : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// List of FFT spectra data points from the data input.
    /// </summary>
    [JsonPropertyName("fftSpectraPoints")]
    public IEnumerable<FftSpectraDataPoint>? FftSpectraPoints { get; set; }

    /// <summary>
    /// List of active J1939D1 statuses.
    /// </summary>
    [JsonPropertyName("j1939D1StatusPoints")]
    public IEnumerable<J1939D1StatusDataPoint>? J1939D1StatusPoints { get; set; }

    /// <summary>
    /// List of location data points from the data input.
    /// </summary>
    [JsonPropertyName("locationPoints")]
    public IEnumerable<LocationDataPoint>? LocationPoints { get; set; }

    /// <summary>
    /// List of numeric data points from the data input.
    /// </summary>
    [JsonPropertyName("numberPoints")]
    public IEnumerable<NumberDataPoint>? NumberPoints { get; set; }

    /// <summary>
    /// List of string data points from the data input.
    /// </summary>
    [JsonPropertyName("stringPoints")]
    public IEnumerable<StringDataPoint>? StringPoints { get; set; }

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
