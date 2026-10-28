using System.Text.Json.Serialization;
using Samsara.Net;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[Serializable]
public record MaintenanceEstimateAttachmentsCreateMaintenanceEstimateAttachmentRequestBody
{
    /// <summary>
    /// Estimate UUID or external ID. The estimate must be editable.
    /// </summary>
    [JsonPropertyName("estimateId")]
    public required string EstimateId { get; set; }

    [JsonPropertyName("file")]
    public MaintenanceEstimateInlineFileRequestBody? File { get; set; }

    /// <summary>
    /// Filename, at most 255 Unicode characters; generated when omitted.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("upload")]
    public MaintenanceAttachmentUploadRequestBody? Upload { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
