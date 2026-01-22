using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// J1939 based data. Null if no data is available.
/// </summary>
[Serializable]
public record V1VehicleMaintenanceJ1939 : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("checkEngineLight")]
    public V1VehicleMaintenanceJ1939CheckEngineLight? CheckEngineLight { get; set; }

    /// <summary>
    /// J1939 DTCs.
    /// </summary>
    [JsonPropertyName("diagnosticTroubleCodes")]
    public IEnumerable<V1VehicleMaintenanceJ1939DiagnosticTroubleCodes>? DiagnosticTroubleCodes { get; set; }

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
