using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record AssetDataInput
{
    /// <summary>
    /// Name of the data group that the data input is associated with
    /// </summary>
    [JsonPropertyName("dataGroup")]
    public string? DataGroup { get; set; }

    /// <summary>
    /// ID of the data input
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("lastPoint")]
    public AssetDataInputLastPoint? LastPoint { get; set; }

    /// <summary>
    /// Name of the data input
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Units of data for this data input
    /// </summary>
    [JsonPropertyName("units")]
    public string? Units { get; set; }

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
