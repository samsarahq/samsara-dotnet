using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record V1VehicleMaintenanceJ1939
{
    [JsonPropertyName("checkEngineLight")]
    public V1VehicleMaintenanceJ1939CheckEngineLight? CheckEngineLight { get; set; }

    /// <summary>
    /// J1939 DTCs.
    /// </summary>
    [JsonPropertyName("diagnosticTroubleCodes")]
    public IEnumerable<V1VehicleMaintenanceJ1939DiagnosticTroubleCodes>? DiagnosticTroubleCodes { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
