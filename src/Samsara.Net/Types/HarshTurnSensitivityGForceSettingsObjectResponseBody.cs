using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record HarshTurnSensitivityGForceSettingsObjectResponseBody
{
    /// <summary>
    /// Harsh turn sensitivity settings for heavy duty vehicle.
    /// </summary>
    [JsonPropertyName("heavyDuty")]
    public string? HeavyDuty { get; set; }

    /// <summary>
    /// Harsh turn sensitivity settings for light duty vehicle.
    /// </summary>
    [JsonPropertyName("lightDuty")]
    public string? LightDuty { get; set; }

    /// <summary>
    /// Harsh turn sensitivity settings for passenger car.
    /// </summary>
    [JsonPropertyName("passenger")]
    public string? Passenger { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
