using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record VehicleStatsFaultCodes
{
    [JsonPropertyName("canBusType")]
    public string? CanBusType { get; set; }

    [JsonPropertyName("j1939")]
    public VehicleStatsFaultCodesJ1939? J1939 { get; set; }

    [JsonPropertyName("obdii")]
    public VehicleStatsFaultCodesObdii? Obdii { get; set; }

    [JsonPropertyName("oem")]
    public VehicleStatsFaultCodesOem? Oem { get; set; }

    [JsonPropertyName("time")]
    public required string Time { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
