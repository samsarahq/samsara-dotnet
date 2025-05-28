using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.CarrierProposedAssignments;

public record CreateCarrierProposedAssignmentRequest
{
    /// <summary>
    /// Time after which this assignment will be active and visible to the driver on the mobile app. Not setting it makes it active now. UTC timestamp in RFC 3339 format. Example: `2020-01-27T07:06:25Z`.
    /// </summary>
    [JsonPropertyName("activeTime")]
    public string? ActiveTime { get; set; }

    /// <summary>
    /// ID for the driver for the driver that this assignment is for. This can be either a unique Samsara ID or an external ID for the driver.
    /// </summary>
    [JsonPropertyName("driverId")]
    public required string DriverId { get; set; }

    /// <summary>
    /// Shipping Documents that this assignment will propose to the driver.
    /// </summary>
    [JsonPropertyName("shippingDocs")]
    public string? ShippingDocs { get; set; }

    /// <summary>
    /// IDs of trailers to propose. This can be either a unique Samsara IDs or an external IDs for the trailers. (forbidden if trailerNames is set)
    /// </summary>
    [JsonPropertyName("trailerIds")]
    public IEnumerable<string>? TrailerIds { get; set; }

    /// <summary>
    /// Names of trailers to propose. (forbidden if trailerIds is set)
    /// </summary>
    [JsonPropertyName("trailerNames")]
    public IEnumerable<string>? TrailerNames { get; set; }

    /// <summary>
    /// ID for the vehicle to propose. This can be either a unique Samsara ID or an external ID for the vehicle.
    /// </summary>
    [JsonPropertyName("vehicleId")]
    public required string VehicleId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
