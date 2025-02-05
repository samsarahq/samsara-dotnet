using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record AlertsGetIncidentsResponseBody
{
    /// <summary>
    /// List of workflow incidents.
    /// </summary>
    [JsonPropertyName("data")]
    public IEnumerable<GetWorkflowIncidentResponseObjectResponseBody> Data { get; set; } =
        new List<GetWorkflowIncidentResponseObjectResponseBody>();

    [JsonPropertyName("pagination")]
    public required GoaPaginationResponseResponseBody Pagination { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
