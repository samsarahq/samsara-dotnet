using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// A configured sensor area on the vehicle with its associated sensors
/// </summary>
public record VehicleSensorConfigurationAreaResponseBody
{
    [JsonPropertyName("cargoSensors")]
    public IEnumerable<SensorResponseBody>? CargoSensors { get; set; }

    [JsonPropertyName("humiditySensors")]
    public IEnumerable<SensorResponseBody>? HumiditySensors { get; set; }

    /// <summary>
    /// Position of the area on vehicle  Valid values: `back`, `front`, `middle`
    /// </summary>
    [JsonPropertyName("position")]
    public required VehicleSensorConfigurationAreaResponseBodyPosition Position { get; set; }

    [JsonPropertyName("temperatureSensors")]
    public IEnumerable<SensorResponseBody>? TemperatureSensors { get; set; }

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
