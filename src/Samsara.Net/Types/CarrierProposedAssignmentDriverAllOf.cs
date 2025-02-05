using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record CarrierProposedAssignmentDriverAllOf
{
    [JsonPropertyName("externalIds")]
    public Dictionary<string, string>? ExternalIds { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
