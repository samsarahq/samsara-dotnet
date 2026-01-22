using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// The harsh acceleration sensitivity settings.
/// </summary>
[Serializable]
public record HarshAccelSensitivityV2SettingsObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

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

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
