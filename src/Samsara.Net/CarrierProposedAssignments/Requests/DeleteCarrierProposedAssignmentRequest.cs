using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.CarrierProposedAssignments;

[Serializable]
public record DeleteCarrierProposedAssignmentRequest
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
