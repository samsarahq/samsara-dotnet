using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.TrailerAssignments;

public record TrailerAssignmentsListRequest
{
    /// <summary>
    /// Timestamp in Unix epoch milliseconds representing the start of the period to fetch. Omitting both startMs and endMs only returns current assignments.
    /// </summary>
    [JsonIgnore]
    public long? StartMs { get; set; }

    /// <summary>
    /// Timestamp in Unix epoch milliseconds representing the end of the period to fetch. Omitting endMs sets endMs as the current time
    /// </summary>
    [JsonIgnore]
    public long? EndMs { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
