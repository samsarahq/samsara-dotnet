using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// A vehicle and its list of location events.
/// </summary>
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
