using System.Text.Json.Serialization;
using Samsara.Net;
using Samsara.Net.Core;

namespace Samsara.Net.DriverVehicleAssignments;

[Serializable]
public record DriverVehicleAssignmentsV2UpdateDriverVehicleAssignmentRequestBody
{
    /// <summary>
    /// The time at which the assignment was made in RFC 3339 format. Millisecond precision and timezones are supported. (Examples: 2019-06-13T19:08:25Z, 2019-06-13T19:08:25.455Z, OR 2015-09-15T14:00:12-04:00).
    /// </summary>
    [JsonPropertyName("assignedAtTime")]
    public string? AssignedAtTime { get; set; }

    /// <summary>
    /// ID of the driver. This can be either a unique Samsara ID or an [external ID](/docs/external-ids) for the driver.
    /// </summary>
    [JsonPropertyName("driverId")]
    public required string DriverId { get; set; }

    /// <summary>
    /// The end time in RFC 3339 format. To make this an ongoing assignment (ie. an assignment with no end time), provide an endTime value of 'null'. Millisecond precision and timezones are supported. (Examples: 2019-06-13T19:08:25Z, 2019-06-13T19:08:25.455Z, OR 2015-09-15T14:00:12-04:00).
    /// </summary>
    [JsonPropertyName("endTime")]
    public string? EndTime { get; set; }

    /// <summary>
    /// Is this driver a passenger?
    /// </summary>
    [JsonPropertyName("isPassenger")]
    public bool? IsPassenger { get; set; }

    [JsonPropertyName("metadata")]
    public PatchDriverVehicleAssignmentsV2RequestBodyMetadataRequestBody? Metadata { get; set; }

    /// <summary>
    /// The start time in RFC 3339 format. Millisecond precision and timezones are supported. (Examples: 2019-06-13T19:08:25Z, 2019-06-13T19:08:25.455Z, OR 2015-09-15T14:00:12-04:00).
    /// </summary>
    [JsonPropertyName("startTime")]
    public required string StartTime { get; set; }

    /// <summary>
    /// ID of the vehicle. This can be either a unique Samsara ID or an [external ID](/docs/external-ids) for the vehicle.
    /// </summary>
    [JsonPropertyName("vehicleId")]
    public required string VehicleId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
