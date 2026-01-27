using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Status of engine lights on J1939 vehicles.
/// </summary>
[Serializable]
public record VehicleStatsFaultCodesJ1939Lights : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// True if the MIL status is nonzero.
    /// </summary>
    [JsonPropertyName("emissionsIsOn")]
    public required bool EmissionsIsOn { get; set; }

    /// <summary>
    /// True if the engine protect lamp status is nonzero.
    /// </summary>
    [JsonPropertyName("protectIsOn")]
    public required bool ProtectIsOn { get; set; }

    /// <summary>
    /// True if the red lamp status is nonzero.
    /// </summary>
    [JsonPropertyName("stopIsOn")]
    public required bool StopIsOn { get; set; }

    /// <summary>
    /// True if the amber lamp status is nonzero.
    /// </summary>
    [JsonPropertyName("warningIsOn")]
    public required bool WarningIsOn { get; set; }

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
