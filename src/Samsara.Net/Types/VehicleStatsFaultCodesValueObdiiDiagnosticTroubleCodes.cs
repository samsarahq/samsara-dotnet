using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Diagnostic trouble code for passenger vehicles.
/// </summary>
[Serializable]
public record VehicleStatsFaultCodesValueObdiiDiagnosticTroubleCodes : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

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
