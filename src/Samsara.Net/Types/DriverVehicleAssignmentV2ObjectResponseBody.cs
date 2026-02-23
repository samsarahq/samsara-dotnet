using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Object with driver assignment info and associated driver and vehicle info.
/// </summary>
[Serializable]
public record DriverVehicleAssignmentV2ObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// An assigned at time in RFC 3339 format. Millisecond precision and timezones are supported. (Examples: 2019-06-13T19:08:25Z, 2019-06-13T19:08:25.455Z, OR 2015-09-15T14:00:12-04:00).
    /// </summary>
    [JsonPropertyName("assignedAtTime")]
    public string? AssignedAtTime { get; set; }

    /// <summary>
    /// Name of the assigning source for the driver assignment record.  Valid values: `invalid`, `unknown`, `HOS`, `idCard`, `static`, `faceId`, `tachograph`, `safetyManual`, `RFID`, `trailer`, `external`, `qrCode`, `driverApp`
    /// </summary>
    [JsonPropertyName("assignmentType")]
    public DriverVehicleAssignmentV2ObjectResponseBodyAssignmentType? AssignmentType { get; set; }

    [JsonPropertyName("driver")]
    public required GoaDriverTinyResponseResponseBody Driver { get; set; }

    /// <summary>
    /// An end time in RFC 3339 format. Omitted if not applicable. Millisecond precision and timezones are supported. (Examples: 2019-06-13T19:08:25Z, 2019-06-13T19:08:25.455Z, OR 2015-09-15T14:00:12-04:00).
    /// </summary>
    [JsonPropertyName("endTime")]
    public string? EndTime { get; set; }

    /// <summary>
    /// Boolean indicating whether the driver is a passenger.
    /// </summary>
    [JsonPropertyName("isPassenger")]
    public required bool IsPassenger { get; set; }

    [JsonPropertyName("metadata")]
    public DriverAssignmentMetadataTinyObjectResponseBody? Metadata { get; set; }

    /// <summary>
    /// A start time in RFC 3339 format. Millisecond precision and timezones are supported. (Examples: 2019-06-13T19:08:25Z, 2019-06-13T19:08:25.455Z, OR 2015-09-15T14:00:12-04:00).
    /// </summary>
    [JsonPropertyName("startTime")]
    public required string StartTime { get; set; }

    [JsonPropertyName("vehicle")]
    public required GoaVehicleTinyResponseResponseBody Vehicle { get; set; }

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
