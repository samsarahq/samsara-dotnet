using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// A single gateway-to-device pairing instruction.
/// </summary>
[Serializable]
public record PairGatewayPairObjectRequestBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The serial of the target device to pair the gateway with, in the standard Samsara serial format (e.g. GFRV-43N-VGX). All Samsara device types -- vehicle, asset, equipment, trailer, industrial, and asset tag (AT) -- expose their currently-paired gateway's serial as the device serial, so the same format applies regardless of device type.
    /// </summary>
    [JsonPropertyName("deviceSerial")]
    public required string DeviceSerial { get; set; }

    /// <summary>
    /// The serial of the gateway to reassign. The gateway must already be activated in the organization.
    /// </summary>
    [JsonPropertyName("gatewaySerial")]
    public required string GatewaySerial { get; set; }

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
