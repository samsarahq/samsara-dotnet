using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record FftSpectraDataPoint
{
    [JsonPropertyName("fftSpectra")]
    public FftSpectraDataPointFftSpectra? FftSpectra { get; set; }

    [JsonPropertyName("time")]
    public string? Time { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
