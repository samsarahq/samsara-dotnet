using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record DataInputSnapshot
{
    /// <summary>
    /// Unique identifier for the data input's asset.
    /// </summary>
    [JsonPropertyName("assetId")]
    public string? AssetId { get; set; }

    /// <summary>
    /// Data group for this data input.
    /// </summary>
    [JsonPropertyName("dataGroup")]
    public string? DataGroup { get; set; }

    /// <summary>
    /// Unique identifier for the data input.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Name of this data input.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Units of data for this data input.
    /// </summary>
    [JsonPropertyName("units")]
    public string? Units { get; set; }

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
