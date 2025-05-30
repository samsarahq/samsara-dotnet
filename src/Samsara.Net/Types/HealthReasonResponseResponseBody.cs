using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Information about an active health reason affecting the device.
/// </summary>
public record HealthReasonResponseResponseBody
{
    /// <summary>
    /// The type of health reason detected.  Valid values: `assetUnplugged`, `cameraMisaligned`, `healthy`, `inwardCameraObstruction`, `irregularRecording`, `lowDeviceBattery`, `missingEldDiagnostics`, `missingVin`, `needsReplacement`, `newlyInstalledDevice`, `noGpsSignal`, `notDetected`, `outwardCameraObstruction`, `recordingTimeRequired`, `unknown`, `vgUnplugged`
    /// </summary>
    [JsonPropertyName("healthReasonCode")]
    public HealthReasonResponseResponseBodyHealthReasonCode? HealthReasonCode { get; set; }

    /// <summary>
    /// The timestamp when this health reason began, in RFC3339 format.
    /// </summary>
    [JsonPropertyName("startTime")]
    public DateTime? StartTime { get; set; }

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
