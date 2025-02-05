using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record DataInputSnapshotAllOf
{
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

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
