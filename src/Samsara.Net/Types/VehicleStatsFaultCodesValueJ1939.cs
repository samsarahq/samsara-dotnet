using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Vehicle fault codes for J1939 vehicles.
/// </summary>
public record VehicleStatsFaultCodesValueJ1939
{
    [JsonPropertyName("checkEngineLights")]
    public VehicleStatsFaultCodesValueJ1939CheckEngineLights? CheckEngineLights { get; set; }

    /// <summary>
    /// Diagnostic trouble codes for J1939 vehicles.
    /// </summary>
    [JsonPropertyName("diagnosticTroubleCodes")]
    public IEnumerable<VehicleStatsFaultCodesValueJ1939DiagnosticTroubleCodes>? DiagnosticTroubleCodes { get; set; }

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
