using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record DataInputResponseAllOf
{
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

    /// <summary>
    /// Additional properties received from the response, if any.
    /// </summary>
    /// <remarks>
    /// [EXPERIMENTAL] This API is experimental and may change in future releases.
    /// </remarks>
    [JsonExtensionData]
    public IDictionary<string, JsonElement> AdditionalProperties { get; internal set; } =
        new Dictionary<string, JsonElement>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
