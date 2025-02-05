using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record TrainingAssignmentsPostTrainingAssignmentsResponseBody
{
    /// <summary>
    /// List of created training assignments.
    /// </summary>
    [JsonPropertyName("data")]
    public IEnumerable<TrainingAssignmentPostResponseObjectResponseBody> Data { get; set; } =
        new List<TrainingAssignmentPostResponseObjectResponseBody>();

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
