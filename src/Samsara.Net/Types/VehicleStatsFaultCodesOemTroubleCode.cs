using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record VehicleStatsFaultCodesOemTroubleCode
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

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
