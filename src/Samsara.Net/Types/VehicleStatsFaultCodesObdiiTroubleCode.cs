using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record VehicleStatsFaultCodesObdiiTroubleCode
{
    /// <summary>
    /// Confirmed DTC codes.
    /// </summary>
    [JsonPropertyName("confirmedDtcs")]
    public IEnumerable<VehicleStatsFaultCodesPassengerDtc>? ConfirmedDtcs { get; set; }

    [JsonPropertyName("ignitionType")]
    public VehicleStatsFaultCodesIgnitionType? IgnitionType { get; set; }

    /// <summary>
    /// The MIL status, indicating a check engine light.
    /// </summary>
    [JsonPropertyName("milStatus")]
    public bool? MilStatus { get; set; }

    [JsonPropertyName("monitorStatus")]
    public VehicleStatsFaultCodesPassengerMonitorStatus? MonitorStatus { get; set; }

    /// <summary>
    /// Pending DTC codes.
    /// </summary>
    [JsonPropertyName("pendingDtcs")]
    public IEnumerable<VehicleStatsFaultCodesPassengerDtc>? PendingDtcs { get; set; }

    /// <summary>
    /// Permanent DTC codes.
    /// </summary>
    [JsonPropertyName("permanentDtcs")]
    public IEnumerable<VehicleStatsFaultCodesPassengerDtc>? PermanentDtcs { get; set; }

    [JsonPropertyName("txId")]
    public required int TxId { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
