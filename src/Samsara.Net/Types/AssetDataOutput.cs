using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record AssetDataOutput
{
    /// <summary>
    /// Name of the data group that the data output is associated with
    /// </summary>
    [JsonPropertyName("dataGroup")]
    public string? DataGroup { get; set; }

    [JsonPropertyName("dataInput")]
    public AssetDataInput? DataInput { get; set; }

    /// <summary>
    /// ID of the device that the data output is configured on
    /// </summary>
    [JsonPropertyName("deviceId")]
    public string? DeviceId { get; set; }

    /// <summary>
    /// ID of the data output
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Name of the data output
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

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
