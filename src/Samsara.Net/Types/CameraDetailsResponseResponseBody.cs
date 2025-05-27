using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Camera-specific health metadata details.
/// </summary>
public record CameraDetailsResponseResponseBody
{
    /// <summary>
    /// The timestamp when the gateway was last connected to the vehicle, in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("gatewayLastConnectedTime")]
    public DateTime? GatewayLastConnectedTime { get; set; }

    /// <summary>
    /// The percentage of successful recording time during the time when the vehicle is on an active trip over the past 50 hours, in percentage points.
    /// </summary>
    [JsonPropertyName("lastFiftyHoursUptimePercentage")]
    public double? LastFiftyHoursUptimePercentage { get; set; }

    /// <summary>
    /// The serial number of the vehicle gateway that the camera is connected to.
    /// </summary>
    [JsonPropertyName("vehicleGatewaySerial")]
    public string? VehicleGatewaySerial { get; set; }

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
