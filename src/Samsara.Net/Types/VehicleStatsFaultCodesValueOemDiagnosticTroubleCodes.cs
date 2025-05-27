using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Proprietary diagnostic trouble code for some OEM vehicles.
/// </summary>
public record VehicleStatsFaultCodesValueOemDiagnosticTroubleCodes
{
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
