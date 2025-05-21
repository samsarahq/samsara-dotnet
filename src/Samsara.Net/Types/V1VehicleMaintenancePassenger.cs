using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Passenger vehicle data. Null if no data is available.
/// </summary>
public record V1VehicleMaintenancePassenger
{
    [JsonPropertyName("checkEngineLight")]
    public V1VehicleMaintenancePassengerCheckEngineLight? CheckEngineLight { get; set; }

    /// <summary>
    /// Passenger vehicle DTCs.
    /// </summary>
    [JsonPropertyName("diagnosticTroubleCodes")]
    public IEnumerable<V1VehicleMaintenancePassengerDiagnosticTroubleCodes>? DiagnosticTroubleCodes { get; set; }

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
