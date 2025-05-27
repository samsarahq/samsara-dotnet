using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// A unit of equipment and its time-series of location events.
/// </summary>
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

    /// <summary>
    /// Additional properties received from the response, if any.
    /// </summary>
    /// <remarks>
    /// [EXPERIMENTAL] This API is experimental and may change in future releases.
    /// </remarks>
    [JsonExtensionData]
    public IDictionary<string, JsonElement> AdditionalProperties { get; internal set; } =
        new Dictionary<string, JsonElement>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
