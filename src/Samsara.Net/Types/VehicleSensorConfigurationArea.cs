using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// The sensor configuration for an area of the vehicle
/// </summary>
public record VehicleSensorConfigurationArea
{
    /// <summary>
    /// Cargo sensors configured in this position of the vehicle
    /// </summary>
    [JsonPropertyName("cargoSensors")]
    public IEnumerable<Sensor>? CargoSensors { get; set; }

    /// <summary>
    /// Humidity sensors configured in this position of the vehicle
    /// </summary>
    [JsonPropertyName("humiditySensors")]
    public IEnumerable<Sensor>? HumiditySensors { get; set; }

    /// <summary>
    /// Position of the area on vehicle
    /// </summary>
    [JsonPropertyName("position")]
    public VehicleSensorConfigurationAreaPosition? Position { get; set; }

    /// <summary>
    /// Temperature sensors configured in this position of the vehicle
    /// </summary>
    [JsonPropertyName("temperatureSensors")]
    public IEnumerable<Sensor>? TemperatureSensors { get; set; }

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
