using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record JobsGetJobsResponseBody
{
    /// <summary>
    /// List of Job Objects
    /// </summary>
    [JsonPropertyName("data")]
    public IEnumerable<JobResponseObjectResponseBody> Data { get; set; } =
        new List<JobResponseObjectResponseBody>();

    /// <summary>
    /// The job id of the failed request
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("pagination")]
    public required GoaPaginationResponseResponseBody Pagination { get; set; }

    /// <summary>
    /// The uuid of the failed request
    /// </summary>
    [JsonPropertyName("uuid")]
    public string? Uuid { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
