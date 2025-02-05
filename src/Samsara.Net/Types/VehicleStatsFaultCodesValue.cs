using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record VehicleStatsFaultCodesValue
{
    /// <summary>
    /// The CAN bus type of the vehicle.
    /// </summary>
    [JsonPropertyName("canBusType")]
    public string? CanBusType { get; set; }

    [JsonPropertyName("j1939")]
    public VehicleStatsFaultCodesValueJ1939? J1939 { get; set; }

    [JsonPropertyName("obdii")]
    public VehicleStatsFaultCodesValueObdii? Obdii { get; set; }

    [JsonPropertyName("oem")]
    public VehicleStatsFaultCodesValueOem? Oem { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
