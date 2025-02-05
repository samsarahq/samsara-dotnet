using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record DriverCoachAssignmentsPutDriverCoachAssignmentResponseBody
{
    [JsonPropertyName("data")]
    public required CoachAssignmentWithoutDriverExternalIdsResponseResponseBody Data { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
