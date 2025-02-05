using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record FormSubmissionRequestAssignedToRequestBody
{
    /// <summary>
    /// ID of the form submission assignee.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// Type of the form submission assignee.  Valid values: `driver`, `user`
    /// </summary>
    [JsonPropertyName("type")]
    public required FormSubmissionRequestAssignedToRequestBodyType Type { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
