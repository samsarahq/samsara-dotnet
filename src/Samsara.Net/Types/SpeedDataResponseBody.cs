using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Details specific to Speed.
/// </summary>
public record SpeedDataResponseBody
{
    /// <summary>
    /// Current speed of the vehicle in kilometers per hour.
    /// </summary>
    [JsonPropertyName("currentSpeedKilometersPerHour")]
    public required int CurrentSpeedKilometersPerHour { get; set; }

    [JsonPropertyName("driver")]
    public AlertObjectDriverResponseBody? Driver { get; set; }

    /// <summary>
    /// Minimum duration of the current speed in milliseconds.
    /// </summary>
    [JsonPropertyName("minDurationMilliseconds")]
    public required long MinDurationMilliseconds { get; set; }

    /// <summary>
    /// Operation of the current and threshold comparison.  Valid values: `GREATER`, `INSIDE_RANGE`, `LESS`, `OUTSIDE_RANGE`
    /// </summary>
    [JsonPropertyName("operation")]
    public required SpeedDataResponseBodyOperation Operation { get; set; }

    /// <summary>
    /// Threshold speed of the vehicle in kilometers per hour.
    /// </summary>
    [JsonPropertyName("thresholdSpeedKilometersPerHour")]
    public required int ThresholdSpeedKilometersPerHour { get; set; }

    [JsonPropertyName("trailer")]
    public AlertObjectTrailerResponseBody? Trailer { get; set; }

    [JsonPropertyName("vehicle")]
    public AlertObjectVehicleResponseBody? Vehicle { get; set; }

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
