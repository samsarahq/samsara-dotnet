using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record HosLogEntry
{
    /// <summary>
    /// The codriver information.
    /// </summary>
    [JsonPropertyName("codrivers")]
    public IEnumerable<DriverTinyResponse>? Codrivers { get; set; }

    /// <summary>
    /// The Hours of Service status type. Valid values: `offDuty`, `sleeperBed`, `driving`, `onDuty`, `yardMove`, `personalConveyance`.
    /// </summary>
    [JsonPropertyName("hosStatusType")]
    public HosLogEntryHosStatusType? HosStatusType { get; set; }

    [JsonPropertyName("logEndTime")]
    public string? LogEndTime { get; set; }

    [JsonPropertyName("logRecordedLocation")]
    public HosLogLocation? LogRecordedLocation { get; set; }

    [JsonPropertyName("logStartTime")]
    public required string LogStartTime { get; set; }

    /// <summary>
    /// Remark associated with the log entry.
    /// </summary>
    [JsonPropertyName("remark")]
    public string? Remark { get; set; }

    [JsonPropertyName("vehicle")]
    public VehicleTinyResponse? Vehicle { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
