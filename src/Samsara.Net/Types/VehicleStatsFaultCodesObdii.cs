using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record VehicleStatsFaultCodesObdii
{
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

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
