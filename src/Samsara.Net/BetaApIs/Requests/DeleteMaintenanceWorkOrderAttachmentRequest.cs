using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[Serializable]
public record DeleteMaintenanceWorkOrderAttachmentRequest
{
    /// <summary>
    /// Attachment ID returned by work-order attachment upload or work-order reads, not the work order ID.
    /// </summary>
    [JsonIgnore]
    public required string Id { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
