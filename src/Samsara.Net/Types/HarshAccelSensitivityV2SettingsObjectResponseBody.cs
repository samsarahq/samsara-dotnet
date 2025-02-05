using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record HarshAccelSensitivityV2SettingsObjectResponseBody
{
    /// <summary>
    /// Harsh acceleration sensitivity settings for heavy duty vehicle.  Valid values: `unknown`, `invalid`, `off`, `low`, `normal`, `high`
    /// </summary>
    [JsonPropertyName("heavyDuty")]
    public HarshAccelSensitivityV2SettingsObjectResponseBodyHeavyDuty? HeavyDuty { get; set; }

    /// <summary>
    /// Harsh acceleration sensitivity settings for light duty vehicle.  Valid values: `unknown`, `invalid`, `off`, `low`, `normal`, `high`
    /// </summary>
    [JsonPropertyName("lightDuty")]
    public HarshAccelSensitivityV2SettingsObjectResponseBodyLightDuty? LightDuty { get; set; }

    /// <summary>
    /// Harsh acceleration sensitivity settings for passenger car.  Valid values: `unknown`, `invalid`, `off`, `low`, `normal`, `high`
    /// </summary>
    [JsonPropertyName("passenger")]
    public HarshAccelSensitivityV2SettingsObjectResponseBodyPassenger? Passenger { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
