using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record HosEldEventObjectResponseBody
{
    /// <summary>
    /// The accumulated meters in the given ignition power on cycle.
    /// </summary>
    [JsonPropertyName("accumulatedVehicleMeters")]
    public long? AccumulatedVehicleMeters { get; set; }

    /// <summary>
    /// The elapsed time in the engine's operation in the given ignition power on cycle.
    /// </summary>
    [JsonPropertyName("elapsedEngineHours")]
    public double? ElapsedEngineHours { get; set; }

    /// <summary>
    /// A dependent attribute on `eldEventType` that specifies the nature of the event, as defined in the ELD Mandate [section 7.20](https://www.ecfr.gov/cgi-bin/retrieveECFR?gp=1&ty=HTML&h=L&mc=true&=PART&n=pt49.5.395#ap49.5.395_138.a).  Valid values: `1`, `2`, `3`, `4`, `5`, `6`, `7`, `8`, `9`
    /// </summary>
    [JsonPropertyName("eldEventCode")]
    public required int EldEventCode { get; set; }

    /// <summary>
    /// An attribute for the event record indicating whether it is automatically recorded, or edited, entered or accepted by the driver, requested by another authenticated user, or assumed from unidentified driver profile, as defined in the ELD Mandate [section 7.22](https://www.ecfr.gov/cgi-bin/retrieveECFR?gp=1&ty=HTML&h=L&mc=true&=PART&n=pt49.5.395#ap49.5.395_138.a).  Valid values: `1`, `2`, `3`, `4`
    /// </summary>
    [JsonPropertyName("eldEventRecordOrigin")]
    public int? EldEventRecordOrigin { get; set; }

    /// <summary>
    /// An attribute for the event record indicating whether an event is active or inactive and further, if inactive, whether it is due to a change or lack of confirmation by the driver or due to a driver's rejection of change request, as defined in the ELD Mandate [section 7.23](https://www.ecfr.gov/cgi-bin/retrieveECFR?gp=1&ty=HTML&h=L&mc=true&=PART&n=pt49.5.395#ap49.5.395_138.a).  Valid values: `1`, `2`, `3`, `4`
    /// </summary>
    [JsonPropertyName("eldEventRecordStatus")]
    public int? EldEventRecordStatus { get; set; }

    /// <summary>
    /// An attribute specifying the type of ELD event, as defined in the ELD Mandate [section 7.25](https://www.ecfr.gov/cgi-bin/retrieveECFR?gp=1&ty=HTML&h=L&mc=true&=PART&n=pt49.5.395#ap49.5.395_138.a).  Valid values: `1`, `2`, `3`, `4`, `5`, `6`, `7`
    /// </summary>
    [JsonPropertyName("eldEventType")]
    public required int EldEventType { get; set; }

    [JsonPropertyName("location")]
    public HosEldEventLocationObjectResponseBody? Location { get; set; }

    /// <summary>
    /// A code that further specifies the underlying malfunction or data diagnostic event, as defined in the ELD Mandate [section 7.34](https://www.ecfr.gov/cgi-bin/retrieveECFR?gp=1&ty=HTML&h=L&mc=true&=PART&n=pt49.5.395#ap49.5.395_138.a).  Valid values: `P`, `E`, `T`, `L`, `R`, `S`, `O`, `1`, `2`, `3`, `4`, `5`, `6`
    /// </summary>
    [JsonPropertyName("malfunctionDiagnosticCode")]
    public HosEldEventObjectResponseBodyMalfunctionDiagnosticCode? MalfunctionDiagnosticCode { get; set; }

    [JsonPropertyName("remark")]
    public HosEldEventRemarkObjectResponseBody? Remark { get; set; }

    /// <summary>
    /// A time in RFC 3339 format. Millisecond precision and timezones are supported. (Examples: 2019-06-13T19:08:25Z, 2019-06-13T19:08:25.455Z, OR 2015-09-15T14:00:12-04:00).
    /// </summary>
    [JsonPropertyName("time")]
    public required string Time { get; set; }

    /// <summary>
    /// The aggregated time of a vehicle's engine's operation since its inception.
    /// </summary>
    [JsonPropertyName("totalEngineHours")]
    public double? TotalEngineHours { get; set; }

    /// <summary>
    /// The total meters recorded for the vehicle.
    /// </summary>
    [JsonPropertyName("totalVehicleMeters")]
    public long? TotalVehicleMeters { get; set; }

    [JsonPropertyName("vehicle")]
    public GoaVehicleTinyResponseResponseBody? Vehicle { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
