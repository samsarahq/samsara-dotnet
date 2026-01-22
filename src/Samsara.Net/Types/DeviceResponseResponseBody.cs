using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Information about a device including its identity, last known location, last connected time, and health status.
/// </summary>
[Serializable]
public record DeviceResponseResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("asset")]
    public required DeviceAssetResponseResponseBody Asset { get; set; }

    [JsonPropertyName("health")]
    public HealthResponseResponseBody? Health { get; set; }

    /// <summary>
    /// The last time the device was connected, in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("lastConnectedTime")]
    public DateTime? LastConnectedTime { get; set; }

    [JsonPropertyName("lastKnownLocation")]
    public LastKnownLocationResponseResponseBody? LastKnownLocation { get; set; }

    /// <summary>
    /// The product model name of the device.  Valid values: `AG24`, `AG24EU`, `AG26`, `AG26EU`, `AG45`, `AG45EU`, `AG46`, `AG46EU`, `AG46P`, `AG46PEU`, `AG51`, `AG51EU`, `AG52`, `AG52EU`, `AG53`, `AG53EU`, `AT11`, `AT11X`, `CM31`, `CM32`, `CM33`, `CM34`, `OEM`, `OEMP`, `OEMR`, `OEMV`, `VG34`, `VG34EU`, `VG34FN`, `VG34M`, `VG54EU`, `VG54NA`, `VG55EU`, `VG55NA`
    /// </summary>
    [JsonPropertyName("model")]
    public required DeviceResponseResponseBodyModel Model { get; set; }

    /// <summary>
    /// The serial number of the device.
    /// </summary>
    [JsonPropertyName("serial")]
    public required string Serial { get; set; }

    /// <summary>
    /// The list of [tags](https://kb.samsara.com/hc/en-us/articles/360026674631-Using-Tags-and-Tag-Nesting) associated with the Device.
    /// </summary>
    [JsonPropertyName("tags")]
    public IEnumerable<GoaTagTinyResponseResponseBody>? Tags { get; set; }

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
