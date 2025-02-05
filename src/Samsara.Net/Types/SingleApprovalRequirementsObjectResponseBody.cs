using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record SingleApprovalRequirementsObjectResponseBody
{
    /// <summary>
    /// List of role IDs representing which user roles can be approvers.
    /// </summary>
    [JsonPropertyName("roleIds")]
    public IEnumerable<string> RoleIds { get; set; } = new List<string>();

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
