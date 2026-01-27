using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// The configurable sensitivity for Harsh Event Detection on CM11/CM12/CM22 devices. Sensitivity can be measured as a numeric g-force value or the following values: `Normal`, `Less Sensitive`, `More Sensitive`.
/// </summary>
[Serializable]
public record HarshEventSensitivitySettingsObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("harshAccelSensitivityGForce")]
    public HarshAccelSensitivityGForceSettingsObjectResponseBody? HarshAccelSensitivityGForce { get; set; }

    [JsonPropertyName("harshBrakeSensitivityGForce")]
    public HarshBrakeSensitivityGForceSettingsObjectResponseBody? HarshBrakeSensitivityGForce { get; set; }

    [JsonPropertyName("harshTurnSensitivityGForce")]
    public HarshTurnSensitivityGForceSettingsObjectResponseBody? HarshTurnSensitivityGForce { get; set; }

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
