using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record HarshBrakeSensitivityV2SettingsObjectResponseBody
{
    /// <summary>
    /// Harsh brake sensitivity settings for heavy duty vehicle.  Valid values: `unknown`, `invalid`, `off`, `veryLow`, `low`, `normal`, `high`
    /// </summary>
    [JsonPropertyName("heavyDuty")]
    public HarshBrakeSensitivityV2SettingsObjectResponseBodyHeavyDuty? HeavyDuty { get; set; }

    /// <summary>
    /// Harsh brake sensitivity settings for light duty vehicle.  Valid values: `unknown`, `invalid`, `off`, `veryLow`, `low`, `normal`, `high`
    /// </summary>
    [JsonPropertyName("lightDuty")]
    public HarshBrakeSensitivityV2SettingsObjectResponseBodyLightDuty? LightDuty { get; set; }

    /// <summary>
    /// Harsh brake sensitivity settings for passenger car.  Valid values: `unknown`, `invalid`, `off`, `veryLow`, `low`, `normal`, `high`
    /// </summary>
    [JsonPropertyName("passenger")]
    public HarshBrakeSensitivityV2SettingsObjectResponseBodyPassenger? Passenger { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
