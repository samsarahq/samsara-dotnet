using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Identifying information for a device involved in a pairing operation.
/// </summary>
[Serializable]
public record PairResultDeviceObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The unique Samsara ID of the device.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// The name of the device.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The serial number of the device.
    /// </summary>
    [JsonPropertyName("serial")]
    public required string Serial { get; set; }

    /// <summary>
    /// The type of the device.  Valid values: `vehicle`, `asset`, `equipment`, `trailer`, `industrial`, `assetTag`
    /// </summary>
    [JsonPropertyName("type")]
    public required PairResultDeviceObjectResponseBodyType Type { get; set; }

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
