using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// J1939 check engine lights.
/// </summary>
[Serializable]
public record V1VehicleMaintenanceJ1939CheckEngineLight : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("emissionsIsOn")]
    public bool? EmissionsIsOn { get; set; }

    [JsonPropertyName("protectIsOn")]
    public bool? ProtectIsOn { get; set; }

    [JsonPropertyName("stopIsOn")]
    public bool? StopIsOn { get; set; }

    [JsonPropertyName("warningIsOn")]
    public bool? WarningIsOn { get; set; }

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
