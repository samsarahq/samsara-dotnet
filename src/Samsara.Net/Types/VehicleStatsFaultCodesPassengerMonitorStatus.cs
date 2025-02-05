using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record VehicleStatsFaultCodesPassengerMonitorStatus
{
    [JsonPropertyName("catalyst")]
    public VehicleStatsFaultCodesPassengerMonitorStatusValue? Catalyst { get; set; }

    [JsonPropertyName("comprehensive")]
    public VehicleStatsFaultCodesPassengerMonitorStatusValue? Comprehensive { get; set; }

    [JsonPropertyName("egr")]
    public VehicleStatsFaultCodesPassengerMonitorStatusValue? Egr { get; set; }

    [JsonPropertyName("evapSystem")]
    public VehicleStatsFaultCodesPassengerMonitorStatusValue? EvapSystem { get; set; }

    [JsonPropertyName("fuel")]
    public VehicleStatsFaultCodesPassengerMonitorStatusValue? Fuel { get; set; }

    [JsonPropertyName("heatedCatalyst")]
    public VehicleStatsFaultCodesPassengerMonitorStatusValue? HeatedCatalyst { get; set; }

    [JsonPropertyName("heatedO2Sensor")]
    public VehicleStatsFaultCodesPassengerMonitorStatusValue? HeatedO2Sensor { get; set; }

    [JsonPropertyName("isoSaeReserved")]
    public VehicleStatsFaultCodesPassengerMonitorStatusValue? IsoSaeReserved { get; set; }

    [JsonPropertyName("misfire")]
    public VehicleStatsFaultCodesPassengerMonitorStatusValue? Misfire { get; set; }

    /// <summary>
    /// Count of the number of sensors reporting N: Not Complete
    /// </summary>
    [JsonPropertyName("notReadyCount")]
    public int? NotReadyCount { get; set; }

    [JsonPropertyName("o2Sensor")]
    public VehicleStatsFaultCodesPassengerMonitorStatusValue? O2Sensor { get; set; }

    [JsonPropertyName("secondaryAir")]
    public VehicleStatsFaultCodesPassengerMonitorStatusValue? SecondaryAir { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
