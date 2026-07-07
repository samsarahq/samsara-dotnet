using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// BLE asset tag-specific health metadata details.
/// </summary>
[Serializable]
public record BleAssetTagDetailsResponseResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The BLE asset tag's battery state.  Valid values: `critical`, `low`, `ok`, `unknown`
    /// </summary>
    [JsonPropertyName("batteryState")]
    public BleAssetTagDetailsResponseResponseBodyBatteryState? BatteryState { get; set; }

    /// <summary>
    /// The timestamp when the BLE asset tag was last detected by a gateway in the Samsara network, in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("lastCheckInTime")]
    public DateTime? LastCheckInTime { get; set; }

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
