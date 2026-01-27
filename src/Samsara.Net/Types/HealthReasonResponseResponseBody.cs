using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Information about an active health reason affecting the device.
/// </summary>
[Serializable]
public record HealthReasonResponseResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The type of health reason detected.  Valid values: `assetUnplugged`, `cameraMisaligned`, `dataPending`, `healthy`, `inwardCameraObstruction`, `irregularRecording`, `lowDeviceBattery`, `missingEldDiagnostics`, `missingVin`, `needsReplacement`, `newlyInstalledDevice`, `noGpsSignal`, `notDetected`, `outwardCameraObstruction`, `recordingTimeRequired`, `unknown`, `vgUnplugged`
    /// </summary>
    [JsonPropertyName("healthReasonCode")]
    public HealthReasonResponseResponseBodyHealthReasonCode? HealthReasonCode { get; set; }

    /// <summary>
    /// The timestamp when this health reason began, in RFC3339 format.
    /// </summary>
    [JsonPropertyName("startTime")]
    public DateTime? StartTime { get; set; }

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
