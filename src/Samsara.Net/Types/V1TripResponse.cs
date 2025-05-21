using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Contains the trips for the vehicle in the requested timeframe. A trip is represented as an object that contains startMs, startLocation, startAddress, startCoordinates, endMs, endLocation, endAddress and endCoordinates. Ongoing trips will be returned with 9223372036854775807 as their endMs.
/// </summary>
public record V1TripResponse
{
    [JsonPropertyName("trips")]
    public IEnumerable<V1TripResponseTrips>? Trips { get; set; }

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
