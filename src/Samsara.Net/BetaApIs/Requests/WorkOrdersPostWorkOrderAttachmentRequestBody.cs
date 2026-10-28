using System.Text.Json.Serialization;
using Samsara.Net;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[Serializable]
public record WorkOrdersPostWorkOrderAttachmentRequestBody
{
    [JsonPropertyName("file")]
    public WorkOrderAttachmentFileRequestBody? File { get; set; }

    [JsonPropertyName("upload")]
    public MaintenanceAttachmentUploadRequestBody? Upload { get; set; }

    /// <summary>
    /// ID of the work order to attach the file to.
    /// </summary>
    [JsonPropertyName("workOrderId")]
    public required string WorkOrderId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
