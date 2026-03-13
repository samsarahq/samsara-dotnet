using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[Serializable]
public record DeviceRecoveryRecoverAssetRequestBody
{
    /// <summary>
    /// The ID of the asset. This can be a Samsara internal ID or an external ID in the format `key:value`.
    /// </summary>
    [JsonIgnore]
    public required string Id { get; set; }

    /// <summary>
    /// Optional additional details about the recovery.
    /// </summary>
    [JsonPropertyName("additional_details")]
    public string? AdditionalDetails { get; set; }

    /// <summary>
    /// The reason the asset was marked as missing.  Valid values: `MISPLACED`, `STOLEN`, `NOT_SURE`
    /// </summary>
    [JsonPropertyName("missing_reason")]
    public required DeviceRecoveryRecoverAssetRequestBodyMissingReason MissingReason { get; set; }

    /// <summary>
    /// Whether the asset has been physically recovered.  Valid values: `YES`, `NO`, `NOT_SURE`
    /// </summary>
    [JsonPropertyName("recovery_status")]
    public required DeviceRecoveryRecoverAssetRequestBodyRecoveryStatus RecoveryStatus { get; set; }

    /// <summary>
    /// The recovery status to set for the asset.  Valid values: `RECOVERED`
    /// </summary>
    [JsonPropertyName("status")]
    public required DeviceRecoveryRecoverAssetRequestBodyStatus Status { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
