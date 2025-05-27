using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Tire pressure readings for each of four tires in kilopascals.
/// </summary>
public record VehicleStatsTirePressures
{
    /// <summary>
    /// The tire pressure of the rear left tire as seen when standing behind the vehicle in kilopascals.
    /// </summary>
    [JsonPropertyName("backLeftTirePressureKPa")]
    public long? BackLeftTirePressureKPa { get; set; }

    /// <summary>
    /// The tire pressure of the rear right tire as seen when standing behind the vehicle in kilopascals.
    /// </summary>
    [JsonPropertyName("backRightTirePressureKPa")]
    public long? BackRightTirePressureKPa { get; set; }

    /// <summary>
    /// The tire pressure of the front left tire as seen when standing behind the vehicle in kilopascals.
    /// </summary>
    [JsonPropertyName("frontLeftTirePressureKPa")]
    public long? FrontLeftTirePressureKPa { get; set; }

    /// <summary>
    /// The tire pressure of the front right tire as seen when standing behind the vehicle in kilopascals.
    /// </summary>
    [JsonPropertyName("frontRightTirePressureKPa")]
    public long? FrontRightTirePressureKPa { get; set; }

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
