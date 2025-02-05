using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record TrailerAssignmentsUpdateDriverTrailerAssignmentResponseBody
{
    [JsonPropertyName("data")]
    public required PatchDriverTrailerAssignmentsResponseBodyResponseBody Data { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
