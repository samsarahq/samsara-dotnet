using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record CarrierProposedAssignmentResponse
{
    [JsonPropertyName("data")]
    public required CarrierProposedAssignment Data { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
