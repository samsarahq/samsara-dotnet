using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record AlertsPatchConfigurationsResponseBody
{
    [JsonPropertyName("data")]
    public required PatchResponseWorkflowConfigurationObjectResponseBody Data { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
