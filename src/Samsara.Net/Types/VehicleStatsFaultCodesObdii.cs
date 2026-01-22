using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Vehicle fault codes for passenger vehicles.
/// </summary>
[Serializable]
public record VehicleStatsFaultCodesObdii : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// True if the check engine light is illuminated (MIL status field is nonzero for any faults).
    /// </summary>
    [JsonPropertyName("checkEngineLightIsOn")]
    public bool? CheckEngineLightIsOn { get; set; }

    /// <summary>
    /// Diagnostic trouble codes for passenger vehicles.
    /// </summary>
    [JsonPropertyName("diagnosticTroubleCodes")]
    public IEnumerable<VehicleStatsFaultCodesObdiiTroubleCode>? DiagnosticTroubleCodes { get; set; }

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
