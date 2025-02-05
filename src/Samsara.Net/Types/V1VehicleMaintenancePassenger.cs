using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record V1VehicleMaintenancePassenger
{
    [JsonPropertyName("checkEngineLight")]
    public V1VehicleMaintenancePassengerCheckEngineLight? CheckEngineLight { get; set; }

    /// <summary>
    /// Passenger vehicle DTCs.
    /// </summary>
    [JsonPropertyName("diagnosticTroubleCodes")]
    public IEnumerable<V1VehicleMaintenancePassengerDiagnosticTroubleCodes>? DiagnosticTroubleCodes { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
