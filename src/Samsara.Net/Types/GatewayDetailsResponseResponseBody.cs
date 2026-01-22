using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Gateway-specific health metadata.
/// </summary>
[Serializable]
public record GatewayDetailsResponseResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("cellConnectivity")]
    public CellConnectivityResponseResponseBody? CellConnectivity { get; set; }

    /// <summary>
    /// The gateway's battery state.  Valid values: `critical`, `low`, `ok`, `unknown`
    /// </summary>
    [JsonPropertyName("gatewayBatteryState")]
    public GatewayDetailsResponseResponseBodyGatewayBatteryState? GatewayBatteryState { get; set; }

    /// <summary>
    /// The battery temperature of the gateway, in degrees Celsius.
    /// </summary>
    [JsonPropertyName("gatewayBatteryTemp")]
    public double? GatewayBatteryTemp { get; set; }

    /// <summary>
    /// The battery voltage of the gateway, in volts.
    /// </summary>
    [JsonPropertyName("gatewayBatteryVolts")]
    public double? GatewayBatteryVolts { get; set; }

    /// <summary>
    /// The timestamp of the gateway's last check-in, in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("lastCheckInTime")]
    public DateTime? LastCheckInTime { get; set; }

    /// <summary>
    /// The battery voltage of the vehicle that gateway is connected to, in volts.
    /// </summary>
    [JsonPropertyName("vehicleBatteryVolts")]
    public double? VehicleBatteryVolts { get; set; }

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
