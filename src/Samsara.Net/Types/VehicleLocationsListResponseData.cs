using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record VehicleLocationsListResponseData
{
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// A list of location events for the given vehicle.
    /// </summary>
    [JsonPropertyName("locations")]
    public IEnumerable<VehicleLocation> Locations { get; set; } = new List<VehicleLocation>();

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
