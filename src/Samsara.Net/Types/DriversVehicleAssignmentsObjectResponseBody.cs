using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[Serializable]
public record DriversVehicleAssignmentsObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

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

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
