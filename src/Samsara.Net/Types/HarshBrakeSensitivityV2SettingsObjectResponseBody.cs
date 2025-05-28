using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// The harsh brake sensitivity settings.
/// </summary>
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
