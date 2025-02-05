using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record CoachingSessionsGetCoachingSessionsResponseBody
{
    /// <summary>
    /// List of coaching sessions objects.
    /// </summary>
    [JsonPropertyName("data")]
    public IEnumerable<CoachingSessionsResponseResponseBody> Data { get; set; } =
        new List<CoachingSessionsResponseResponseBody>();

    [JsonPropertyName("pagination")]
    public required GoaPaginationResponseResponseBody Pagination { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
