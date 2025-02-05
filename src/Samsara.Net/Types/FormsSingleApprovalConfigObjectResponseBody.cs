using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record FormsSingleApprovalConfigObjectResponseBody
{
    /// <summary>
    /// Indicates whether approver can be manually selected. True by default.
    /// </summary>
    [JsonPropertyName("allowManualApproverSelection")]
    public required bool AllowManualApproverSelection { get; set; }

    [JsonPropertyName("requirements")]
    public required SingleApprovalRequirementsObjectResponseBody Requirements { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
