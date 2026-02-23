using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Fleet.CarrierProposedAssignments;

[Serializable]
public record DeleteCarrierProposedAssignmentsRequest
{
    /// <summary>
    /// ID of the assignment.
    /// </summary>
    [JsonIgnore]
    public required string Id { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
