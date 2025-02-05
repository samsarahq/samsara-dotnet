using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record V1TrailerAssignmentsResponse
{
    /// <summary>
    /// ID of the trailer
    /// </summary>
    [JsonPropertyName("id")]
    public required long Id { get; set; }

    /// <summary>
    /// Assignment trailer name (given when creating trailer via the trailer portal)
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("trailerAssignments")]
    public IEnumerable<V1TrailerAssignmentResponse>? TrailerAssignments { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
