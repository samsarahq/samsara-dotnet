using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// A device (vehicle or trailer) related to the DVIR.
/// </summary>
[Serializable]
public record Dvir2RelatedDeviceObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The type of asset.  Valid values: `Vehicle`, `Trailer`
    /// </summary>
    [JsonPropertyName("assetType")]
    public required Dvir2RelatedDeviceObjectResponseBodyAssetType AssetType { get; set; }

    [JsonPropertyName("device")]
    public Dvir2DeviceObjectResponseBody? Device { get; set; }

    /// <summary>
    /// The ID of the device.
    /// </summary>
    [JsonPropertyName("deviceId")]
    public required long DeviceId { get; set; }

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
