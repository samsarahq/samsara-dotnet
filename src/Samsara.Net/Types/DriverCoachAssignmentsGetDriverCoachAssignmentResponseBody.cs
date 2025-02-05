using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record DriverCoachAssignmentsGetDriverCoachAssignmentResponseBody
{
    /// <summary>
    /// List of driver coach assignment objects
    /// </summary>
    [JsonPropertyName("data")]
    public IEnumerable<CoachAssignmentWithDriverExternalIdsResponseResponseBody> Data { get; set; } =
        new List<CoachAssignmentWithDriverExternalIdsResponseResponseBody>();

    [JsonPropertyName("pagination")]
    public required GoaPaginationResponseResponseBody Pagination { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
