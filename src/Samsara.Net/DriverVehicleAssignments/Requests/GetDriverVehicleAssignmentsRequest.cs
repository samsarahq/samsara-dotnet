using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.DriverVehicleAssignments;

[Serializable]
public record GetDriverVehicleAssignmentsRequest
{
    /// <summary>
    /// Option to filter by drivers or vehicles.  Valid values: `drivers`, `vehicles`
    /// </summary>
    [JsonIgnore]
    public required GetDriverVehicleAssignmentsRequestFilterBy FilterBy { get; set; }

    /// <summary>
    /// A start time in RFC 3339 format. Defaults to now if not provided. Millisecond precision and timezones are supported. (Examples: 2019-06-13T19:08:25Z, 2019-06-13T19:08:25.455Z, OR 2015-09-15T14:00:12-04:00).
    /// </summary>
    [JsonIgnore]
    public string? StartTime { get; set; }

    /// <summary>
    /// An end time in RFC 3339 format. Defaults to now if not provided. Millisecond precision and timezones are supported. (Examples: 2019-06-13T19:08:25Z, 2019-06-13T19:08:25.455Z, OR 2015-09-15T14:00:12-04:00).
    /// </summary>
    [JsonIgnore]
    public string? EndTime { get; set; }

    /// <summary>
    /// A filter on the data based on this comma-separated list of driver IDs and externalIds. Example: `driverIds=1234,5678,payroll:4841`
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> DriverIds { get; set; } = new List<string>();

    /// <summary>
    /// ID of the vehicle. This can either be the Samsara-specified ID, or an external ID. External IDs are customer specified key-value pairs created in the POST or PATCH requests of this resource. To specify an external ID as part of a path parameter, use the following format: "key:value". For example, "maintenanceId:250020".
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> VehicleIds { get; set; } = new List<string>();

    /// <summary>
    /// A filter on the data based on this comma-separated list of driver tag IDs. Example: `tagIds=1234,5678`
    /// </summary>
    [JsonIgnore]
    public string? DriverTagIds { get; set; }

    /// <summary>
    /// A filter on the data based on this comma-separated list of vehicle tag IDs. Example: `tagIds=1234,5678`
    /// </summary>
    [JsonIgnore]
    public string? VehicleTagIds { get; set; }

    /// <summary>
    /// If specified, this should be the endCursor value from the previous page of results. When present, this request will return the next page of results that occur immediately after the previous page of results.
    /// </summary>
    [JsonIgnore]
    public string? After { get; set; }

    /// <summary>
    /// Specifies which assignment type to filter by.  Valid values: `HOS`, `idCard`, `static`, `faceId`, `tachograph`, `safetyManual`, `RFID`, `trailer`, `external`, `qrCode`
    /// </summary>
    [JsonIgnore]
    public GetDriverVehicleAssignmentsRequestAssignmentType? AssignmentType { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
