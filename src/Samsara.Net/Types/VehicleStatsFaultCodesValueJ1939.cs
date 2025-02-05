using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record VehicleStatsFaultCodesValueJ1939
{
    [JsonPropertyName("checkEngineLights")]
    public VehicleStatsFaultCodesValueJ1939CheckEngineLights? CheckEngineLights { get; set; }

    /// <summary>
    /// Diagnostic trouble codes for J1939 vehicles.
    /// </summary>
    [JsonPropertyName("diagnosticTroubleCodes")]
    public IEnumerable<VehicleStatsFaultCodesValueJ1939DiagnosticTroubleCodes>? DiagnosticTroubleCodes { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
