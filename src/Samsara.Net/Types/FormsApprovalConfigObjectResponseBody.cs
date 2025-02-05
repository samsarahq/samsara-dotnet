using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record FormsApprovalConfigObjectResponseBody
{
    [JsonPropertyName("singleApprovalConfig")]
    public FormsSingleApprovalConfigObjectResponseBody? SingleApprovalConfig { get; set; }

    /// <summary>
    /// Type of approval.  Valid values: `singleApproval`
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
