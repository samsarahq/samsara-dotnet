using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record HarshTurnSensitivityV2SettingsObjectResponseBody
{
    /// <summary>
    /// Harsh turn sensitivity settings for heavy duty vehicle.  Valid values: `unknown`, `invalid`, `off`, `veryLow`, `low`, `normal`, `high`
    /// </summary>
    [JsonPropertyName("heavyDuty")]
    public HarshTurnSensitivityV2SettingsObjectResponseBodyHeavyDuty? HeavyDuty { get; set; }

    /// <summary>
    /// Harsh turn sensitivity settings for light duty vehicle.  Valid values: `unknown`, `invalid`, `off`, `veryLow`, `low`, `normal`, `high`
    /// </summary>
    [JsonPropertyName("lightDuty")]
    public HarshTurnSensitivityV2SettingsObjectResponseBodyLightDuty? LightDuty { get; set; }

    /// <summary>
    /// Harsh turn sensitivity settings for passenger car.  Valid values: `unknown`, `invalid`, `off`, `veryLow`, `low`, `normal`, `high`
    /// </summary>
    [JsonPropertyName("passenger")]
    public HarshTurnSensitivityV2SettingsObjectResponseBodyPassenger? Passenger { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
