using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record VehicleStatsFaultCodesOem
{
    [JsonPropertyName("diagnosticTroubleCodes")]
    public IEnumerable<VehicleStatsFaultCodesOemTroubleCode>? DiagnosticTroubleCodes { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
