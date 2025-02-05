using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record AlertsPostConfigurationsResponseBody
{
    [JsonPropertyName("data")]
    public required PostResponseResWorkflowConfigurationObjectResponseBody Data { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
