using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record TrainingAssignmentsPatchTrainingAssignmentsResponseBody
{
    /// <summary>
    /// List of updated training assignments.
    /// </summary>
    [JsonPropertyName("data")]
    public IEnumerable<TrainingAssignmentResponseObjectResponseBody> Data { get; set; } =
        new List<TrainingAssignmentResponseObjectResponseBody>();

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
