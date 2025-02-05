using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record EquipmentLocationsListResponseData
{
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// A time-series of location events for the given unit of equipment.
    /// </summary>
    [JsonPropertyName("locations")]
    public IEnumerable<EquipmentLocation> Locations { get; set; } = new List<EquipmentLocation>();

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
