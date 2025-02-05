using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record VehicleStatsFaultCodesJ1939
{
    [JsonPropertyName("checkEngineLights")]
    public VehicleStatsFaultCodesJ1939Lights? CheckEngineLights { get; set; }

    [JsonPropertyName("diagnosticTroubleCodes")]
    public IEnumerable<VehicleStatsFaultCodesJ1939TroubleCode>? DiagnosticTroubleCodes { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
