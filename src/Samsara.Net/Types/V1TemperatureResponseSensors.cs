using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record V1TemperatureResponseSensors
{
    /// <summary>
    /// Currently reported ambient temperature in millidegrees celsius.
    /// </summary>
    [JsonPropertyName("ambientTemperature")]
    public int? AmbientTemperature { get; set; }

    /// <summary>
    /// The timestamp of reported ambient temperature, specified in RFC 3339 time.
    /// </summary>
    [JsonPropertyName("ambientTemperatureTime")]
    public string? AmbientTemperatureTime { get; set; }

    /// <summary>
    /// ID of the sensor.
    /// </summary>
    [JsonPropertyName("id")]
    public long? Id { get; set; }

    /// <summary>
    /// Name of the sensor.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Currently reported probe temperature in millidegrees celsius. If no probe is connected, this parameter will not be reported.
    /// </summary>
    [JsonPropertyName("probeTemperature")]
    public int? ProbeTemperature { get; set; }

    /// <summary>
    /// The timestamp of reported probe temperature, specified in RFC 3339 time.
    /// </summary>
    [JsonPropertyName("probeTemperatureTime")]
    public string? ProbeTemperatureTime { get; set; }

    /// <summary>
    /// ID of the trailer associated with the sensor for the data point. If no trailer is connected, this parameter will not be reported.
    /// </summary>
    [JsonPropertyName("trailerId")]
    public int? TrailerId { get; set; }

    /// <summary>
    /// ID of the vehicle associated with the sensor for the data point. If no vehicle is connected, this parameter will not be reported.
    /// </summary>
    [JsonPropertyName("vehicleId")]
    public int? VehicleId { get; set; }

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
