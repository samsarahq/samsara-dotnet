using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[Serializable]
public record ResolveAssignmentByDetailsResolveAssignmentByDetailsRequestBody
{
    /// <summary>
    /// The full name of the driver to resolve.
    /// </summary>
    [JsonPropertyName("driverName")]
    public required string DriverName { get; set; }

    /// <summary>
    /// The vehicle ID. This can be either a unique Samsara ID or an external ID for the vehicle.
    /// </summary>
    [JsonPropertyName("vehicleId")]
    public required string VehicleId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
