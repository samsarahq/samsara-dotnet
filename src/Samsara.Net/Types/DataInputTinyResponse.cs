using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record DataInputTinyResponse
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

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
