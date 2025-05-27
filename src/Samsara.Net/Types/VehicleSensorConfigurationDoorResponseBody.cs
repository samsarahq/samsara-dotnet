using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// A door monitor configuration on a vehicle
/// </summary>
public record VehicleSensorConfigurationDoorResponseBody
{
    /// <summary>
    /// Position of the door monitor on the vehicle  Valid values: `back`, `left`, `right`
    /// </summary>
    [JsonPropertyName("position")]
    public required VehicleSensorConfigurationDoorResponseBodyPosition Position { get; set; }

    [JsonPropertyName("sensor")]
    public required SensorResponseBody Sensor { get; set; }

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
