using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record PostCustomReportRunResponseObjectResponseBody
{
    /// <summary>
    /// Time of when the custom report run was created and queued in UTC.
    /// </summary>
    [JsonPropertyName("createdAtTime")]
    public required DateTime CreatedAtTime { get; set; }

    /// <summary>
    /// Unique Id for the custom report (config) linked to this run.
    /// </summary>
    [JsonPropertyName("customReportId")]
    public required string CustomReportId { get; set; }

    /// <summary>
    /// Unique id for the custom report run object.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
