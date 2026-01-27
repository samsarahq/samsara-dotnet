using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Vehicle fault codes for J1939 vehicles.
/// </summary>
[Serializable]
public record VehicleStatsFaultCodesValueJ1939 : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("checkEngineLights")]
    public VehicleStatsFaultCodesValueJ1939CheckEngineLights? CheckEngineLights { get; set; }

    /// <summary>
    /// Diagnostic trouble codes for J1939 vehicles.
    /// </summary>
    [JsonPropertyName("diagnosticTroubleCodes")]
    public IEnumerable<VehicleStatsFaultCodesValueJ1939DiagnosticTroubleCodes>? DiagnosticTroubleCodes { get; set; }

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
