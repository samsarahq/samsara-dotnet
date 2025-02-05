using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record V1FleetVehiclesLocationsItem
{
    /// <summary>
    /// ID of the vehicle.
    /// </summary>
    [JsonPropertyName("id")]
    public long? Id { get; set; }

    [JsonPropertyName("locations")]
    public IEnumerable<V1FleetVehicleLocation>? Locations { get; set; }

    /// <summary>
    /// Name of the vehicle.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
