using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record AlertsGetConfigurationsResponseBody
{
    /// <summary>
    /// List of alert configurations.
    /// </summary>
    [JsonPropertyName("data")]
    public IEnumerable<GetResponseWorkflowConfigurationObjectResponseBody> Data { get; set; } =
        new List<GetResponseWorkflowConfigurationObjectResponseBody>();

    [JsonPropertyName("pagination")]
    public required GoaPaginationResponseResponseBody Pagination { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
