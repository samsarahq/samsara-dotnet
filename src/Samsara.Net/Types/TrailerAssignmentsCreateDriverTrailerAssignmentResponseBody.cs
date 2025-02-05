using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record TrailerAssignmentsCreateDriverTrailerAssignmentResponseBody
{
    [JsonPropertyName("data")]
    public required PostDriverTrailerAssignmentsResponseBodyResponseBody Data { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
