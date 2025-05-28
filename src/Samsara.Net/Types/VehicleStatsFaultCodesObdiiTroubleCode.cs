using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Diagnostic trouble code for passenger vehicles.
/// </summary>
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
