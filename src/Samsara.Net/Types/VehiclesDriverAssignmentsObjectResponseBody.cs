using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record VehiclesDriverAssignmentsObjectResponseBody
{
    /// <summary>
    /// List of driver assignment objects.
    /// </summary>
    [JsonPropertyName("driverAssignments")]
    public IEnumerable<DriverAssignmentObjectResponseBody> DriverAssignments { get; set; } =
        new List<DriverAssignmentObjectResponseBody>();

    /// <summary>
    /// A map of external ids
    /// </summary>
    [JsonPropertyName("externalIds")]
    public Dictionary<string, string>? ExternalIds { get; set; }

    /// <summary>
    /// ID of the vehicle.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// Name of the vehicle.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
