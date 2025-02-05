using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record HosClocksForDriver
{
    [JsonPropertyName("clocks")]
    public HosClocks? Clocks { get; set; }

    [JsonPropertyName("currentDutyStatus")]
    public CurrentDutyStatus? CurrentDutyStatus { get; set; }

    [JsonPropertyName("currentVehicle")]
    public VehicleTinyResponse? CurrentVehicle { get; set; }

    [JsonPropertyName("driver")]
    public DriverTinyResponse? Driver { get; set; }

    [JsonPropertyName("violations")]
    public HosViolations? Violations { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
