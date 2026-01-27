using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// The configurable sensitivity for Harsh Event Detection. Does not apply to CM11/12/22 devices.
/// </summary>
[Serializable]
public record HarshEventSensitivityV2SettingsObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("harshAccelSensitivity")]
    public HarshAccelSensitivityV2SettingsObjectResponseBody? HarshAccelSensitivity { get; set; }

    [JsonPropertyName("harshBrakeSensitivity")]
    public HarshBrakeSensitivityV2SettingsObjectResponseBody? HarshBrakeSensitivity { get; set; }

    [JsonPropertyName("harshTurnSensitivity")]
    public HarshTurnSensitivityV2SettingsObjectResponseBody? HarshTurnSensitivity { get; set; }

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
