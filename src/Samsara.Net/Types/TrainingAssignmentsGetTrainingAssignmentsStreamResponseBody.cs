using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record TrainingAssignmentsGetTrainingAssignmentsStreamResponseBody
{
    /// <summary>
    /// List of training assignments.
    /// </summary>
    [JsonPropertyName("data")]
    public IEnumerable<TrainingAssignmentResponseObjectResponseBody> Data { get; set; } =
        new List<TrainingAssignmentResponseObjectResponseBody>();

    [JsonPropertyName("pagination")]
    public required GoaPaginationResponseResponseBody Pagination { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
