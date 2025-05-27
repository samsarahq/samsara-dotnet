using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record DriversVehicleAssignmentsObjectResponseBody
{
    /// <summary>
    /// A value indicating whether the driver is active or deactivated.  Valid values: `active`, `deactivated`
    /// </summary>
    [JsonPropertyName("driverActivationStatus")]
    public required DriversVehicleAssignmentsObjectResponseBodyDriverActivationStatus DriverActivationStatus { get; set; }

    /// <summary>
    /// A map of external ids
    /// </summary>
    [JsonPropertyName("externalIds")]
    public Dictionary<string, string>? ExternalIds { get; set; }

    /// <summary>
    /// ID of the driver.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// Name of the driver.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// List of vehicle assignment objects.
    /// </summary>
    [JsonPropertyName("vehicleAssignments")]
    public IEnumerable<VehicleAssignmentObjectResponseBody> VehicleAssignments { get; set; } =
        new List<VehicleAssignmentObjectResponseBody>();

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
