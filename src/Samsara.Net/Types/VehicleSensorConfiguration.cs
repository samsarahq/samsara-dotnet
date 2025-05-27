using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// The sensors configured on a vehicle
/// </summary>
public record VehicleSensorConfiguration
{
    [JsonPropertyName("areas")]
    public IEnumerable<VehicleSensorConfigurationArea>? Areas { get; set; }

    [JsonPropertyName("doors")]
    public IEnumerable<VehicleSensorConfigurationDoor>? Doors { get; set; }

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
