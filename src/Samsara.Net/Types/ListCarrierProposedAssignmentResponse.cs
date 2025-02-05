using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record ListCarrierProposedAssignmentResponse
{
    /// <summary>
    /// A list of carrier-proposed assignments
    /// </summary>
    [JsonPropertyName("data")]
    public IEnumerable<CarrierProposedAssignment> Data { get; set; } =
        new List<CarrierProposedAssignment>();

    [JsonPropertyName("pagination")]
    public required PaginationResponse Pagination { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
