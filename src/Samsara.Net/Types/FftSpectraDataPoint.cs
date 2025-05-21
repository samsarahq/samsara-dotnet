using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// FFT spectrum data point of a data input.
/// </summary>
public record FftSpectraDataPoint
{
    [JsonPropertyName("fftSpectra")]
    public FftSpectraDataPointFftSpectra? FftSpectra { get; set; }

    [JsonPropertyName("time")]
    public string? Time { get; set; }

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
