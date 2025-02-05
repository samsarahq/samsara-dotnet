using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record VehicleStatsFaultCodesValueOem
{
    /// <summary>
    /// Proprietary diagnostic trouble codes for OEM vehicles.
    /// </summary>
    [JsonPropertyName("diagnosticTroubleCodes")]
    public IEnumerable<VehicleStatsFaultCodesValueOemDiagnosticTroubleCodes>? DiagnosticTroubleCodes { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
