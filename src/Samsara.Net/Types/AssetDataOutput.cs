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

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
