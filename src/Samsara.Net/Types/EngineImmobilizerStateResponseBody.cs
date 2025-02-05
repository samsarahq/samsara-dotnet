using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record EngineImmobilizerStateResponseBody
{
    /// <summary>
    /// A UTC time in RFC 3339 format. Millisecond precision and timezones are supported. (Examples: 2019-06-13T19:08:25Z, 2019-06-13T19:08:25.455Z, OR 2015-09-15T14:00:12-04:00).
    /// </summary>
    [JsonPropertyName("happenedAtTime")]
    public required string HappenedAtTime { get; set; }

    /// <summary>
    /// Whether the engine immobilizer is connected the vehicle.
    /// </summary>
    [JsonPropertyName("isConnectedToVehicle")]
    public required bool IsConnectedToVehicle { get; set; }

    /// <summary>
    /// A list of states for each relay
    /// </summary>
    [JsonPropertyName("relayStates")]
    public IEnumerable<EngineImmobilizerRelayStateResponseBody> RelayStates { get; set; } =
        new List<EngineImmobilizerRelayStateResponseBody>();

    /// <summary>
    /// The ID of the vehicle that the engine immobilizer is connected to.
    /// </summary>
    [JsonPropertyName("vehicleId")]
    public required string VehicleId { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
