using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record V1VehicleMaintenance
{
    /// <summary>
    /// ID of the vehicle.
    /// </summary>
    [JsonPropertyName("id")]
    public required long Id { get; set; }

    [JsonPropertyName("j1939")]
    public V1VehicleMaintenanceJ1939? J1939 { get; set; }

    [JsonPropertyName("passenger")]
    public V1VehicleMaintenancePassenger? Passenger { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
