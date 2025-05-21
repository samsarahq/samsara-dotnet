using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Contains any J1939/Passenger engine light warnings and engine faults.
/// </summary>
public record V1VehicleMaintenance
{
    /// <summary>
    /// ID of the vehicle.
    /// </summary>
    [JsonPropertyName("id")]
    public required long Id { get; set; }

    [JsonPropertyName("j1939")]
    public V1VehicleMaintenanceJ1939? J1939 { get; set; }

    [JsonPropertyName("passenger")]
    public V1VehicleMaintenancePassenger? Passenger { get; set; }

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
