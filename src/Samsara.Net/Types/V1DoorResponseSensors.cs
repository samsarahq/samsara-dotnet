using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record V1DoorResponseSensors
{
    /// <summary>
    /// Flag indicating whether the current door is closed or open.
    /// </summary>
    [JsonPropertyName("doorClosed")]
    public bool? DoorClosed { get; set; }

    /// <summary>
    /// The timestamp of reported door status, specified in RFC 3339 time.
    /// </summary>
    [JsonPropertyName("doorStatusTime")]
    public string? DoorStatusTime { get; set; }

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
    /// ID of the trailer associated with the sensor for the data point. If no trailer is connected, this parameter will not be reported.
    /// </summary>
    [JsonPropertyName("trailerId")]
    public int? TrailerId { get; set; }

    /// <summary>
    /// ID of the vehicle associated with the sensor for the data point. If no vehicle is connected, this parameter will not be reported.
    /// </summary>
    [JsonPropertyName("vehicleId")]
    public int? VehicleId { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
