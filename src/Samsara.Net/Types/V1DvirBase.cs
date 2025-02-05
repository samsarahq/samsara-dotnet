using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record V1DvirBase
{
    [JsonPropertyName("authorSignature")]
    public V1DvirBaseAuthorSignature? AuthorSignature { get; set; }

    /// <summary>
    /// Signifies if the defects on the vehicle corrected after the DVIR is done.
    /// </summary>
    [JsonPropertyName("defectsCorrected")]
    public bool? DefectsCorrected { get; set; }

    /// <summary>
    /// Signifies if the defects on this vehicle can be ignored.
    /// </summary>
    [JsonPropertyName("defectsNeedNotBeCorrected")]
    public bool? DefectsNeedNotBeCorrected { get; set; }

    /// <summary>
    /// The id of this DVIR record.
    /// </summary>
    [JsonPropertyName("id")]
    public long? Id { get; set; }

    /// <summary>
    /// Inspection type of the DVIR. Valid values: `preTrip`, `postTrip`, `mechanic`, `unspecified`.
    /// </summary>
    [JsonPropertyName("inspectionType")]
    public string? InspectionType { get; set; }

    /// <summary>
    /// The mechanics notes on the DVIR.
    /// </summary>
    [JsonPropertyName("mechanicNotes")]
    public string? MechanicNotes { get; set; }

    [JsonPropertyName("mechanicOrAgentSignature")]
    public V1DvirBaseMechanicOrAgentSignature? MechanicOrAgentSignature { get; set; }

    [JsonPropertyName("nextDriverSignature")]
    public V1DvirBaseNextDriverSignature? NextDriverSignature { get; set; }

    /// <summary>
    /// The odometer reading in miles for the vehicle when the DVIR was done.
    /// </summary>
    [JsonPropertyName("odometerMiles")]
    public long? OdometerMiles { get; set; }

    /// <summary>
    /// Timestamp when driver began filling out this DVIR, in UNIX milliseconds.
    /// </summary>
    [JsonPropertyName("startedAtMs")]
    public long? StartedAtMs { get; set; }

    /// <summary>
    /// Timestamp of when this DVIR was signed & completed, in UNIX milliseconds.
    /// </summary>
    [JsonPropertyName("timeMs")]
    public long? TimeMs { get; set; }

    /// <summary>
    /// Defects registered for the trailer which was part of the DVIR.
    /// </summary>
    [JsonPropertyName("trailerDefects")]
    public IEnumerable<V1DvirDefectBase>? TrailerDefects { get; set; }

    /// <summary>
    /// The id of the trailer which was part of the DVIR.
    /// </summary>
    [JsonPropertyName("trailerId")]
    public int? TrailerId { get; set; }

    /// <summary>
    /// The name of the trailer which was part of the DVIR.
    /// </summary>
    [JsonPropertyName("trailerName")]
    public string? TrailerName { get; set; }

    [JsonPropertyName("vehicle")]
    public V1DvirBaseVehicle? Vehicle { get; set; }

    /// <summary>
    /// The condition of vechile on which DVIR was done.
    /// </summary>
    [JsonPropertyName("vehicleCondition")]
    public string? VehicleCondition { get; set; }

    /// <summary>
    /// Defects registered for the vehicle which was part of the DVIR.
    /// </summary>
    [JsonPropertyName("vehicleDefects")]
    public IEnumerable<V1DvirDefectBase>? VehicleDefects { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
