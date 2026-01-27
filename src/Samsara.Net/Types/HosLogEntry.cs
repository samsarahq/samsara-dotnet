using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// A single HOS log entry.
/// </summary>
[Serializable]
public record HosLogEntry : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

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
