using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record TrailerAssignmentsGetDriverTrailerAssignmentsResponseBody
{
    /// <summary>
    /// List of driver trailer assignment objects and their respective driver and trailer info.
    /// </summary>
    [JsonPropertyName("data")]
    public IEnumerable<GetDriverTrailerAssignmentsResponseBodyResponseBody> Data { get; set; } =
        new List<GetDriverTrailerAssignmentsResponseBodyResponseBody>();

    [JsonPropertyName("pagination")]
    public required GoaPaginationResponseResponseBody Pagination { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
