using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

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

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
