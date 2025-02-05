using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record FftSpectraDataPointFftSpectra
{
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

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
