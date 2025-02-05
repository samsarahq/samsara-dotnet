using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record V1TrailerAssignmentsResponseAllOf
{
    [JsonPropertyName("trailerAssignments")]
    public IEnumerable<V1TrailerAssignmentResponse>? TrailerAssignments { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
