using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record VehicleStatsFaultCodesValueObdiiDiagnosticTroubleCodes
{
    /// <summary>
    /// Confirmed DTC codes.
    /// </summary>
    [JsonPropertyName("confirmedDtcs")]
    public IEnumerable<VehicleStatsFaultCodesValueObdiiConfirmedDtcs>? ConfirmedDtcs { get; set; }

    /// <summary>
    /// The ignition type of this passenger vehicle. Valid values: `spark`, `compression`.
    /// </summary>
    [JsonPropertyName("ignitionType")]
    public VehicleStatsFaultCodesValueObdiiDiagnosticTroubleCodesIgnitionType? IgnitionType { get; set; }

    /// <summary>
    /// The MIL status, indicating a check engine light.
    /// </summary>
    [JsonPropertyName("milStatus")]
    public bool? MilStatus { get; set; }

    [JsonPropertyName("monitorStatus")]
    public VehicleStatsFaultCodesValueObdiiMonitorStatus? MonitorStatus { get; set; }

    /// <summary>
    /// Pending DTC codes.
    /// </summary>
    [JsonPropertyName("pendingDtcs")]
    public IEnumerable<VehicleStatsFaultCodesValueObdiiConfirmedDtcs>? PendingDtcs { get; set; }

    /// <summary>
    /// Permanent DTC codes.
    /// </summary>
    [JsonPropertyName("permanentDtcs")]
    public IEnumerable<VehicleStatsFaultCodesValueObdiiConfirmedDtcs>? PermanentDtcs { get; set; }

    /// <summary>
    /// The TX identifier.
    /// </summary>
    [JsonPropertyName("txId")]
    public required int TxId { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
