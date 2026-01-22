using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Proprietary diagnostic trouble code for some OEM vehicles.
/// </summary>
[Serializable]
public record VehicleStatsFaultCodesOemTroubleCode : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The OEM code description.
    /// </summary>
    [JsonPropertyName("codeDescription")]
    public string? CodeDescription { get; set; }

    /// <summary>
    /// The OEM code identifier.
    /// </summary>
    [JsonPropertyName("codeIdentifier")]
    public string? CodeIdentifier { get; set; }

    /// <summary>
    /// The OEM code severity.
    /// </summary>
    [JsonPropertyName("codeSeverity")]
    public string? CodeSeverity { get; set; }

    /// <summary>
    /// The OEM code source.
    /// </summary>
    [JsonPropertyName("codeSource")]
    public string? CodeSource { get; set; }

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
