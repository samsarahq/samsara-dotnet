using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record GetCustomReportRunObjectResponseBody
{
    /// <summary>
    /// The optional array of attribute value ids to filter the custom report run data by.
    /// </summary>
    [JsonPropertyName("attributeValueIds")]
    public IEnumerable<string>? AttributeValueIds { get; set; }

    /// <summary>
    /// Time of when the custom report run was created in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("createdAtTime")]
    public required DateTime CreatedAtTime { get; set; }

    /// <summary>
    /// Unique ID for the custom report that it belongs to.
    /// </summary>
    [JsonPropertyName("customReportId")]
    public required string CustomReportId { get; set; }

    /// <summary>
    /// The end time of the custom report run in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("endTime")]
    public required DateTime EndTime { get; set; }

    /// <summary>
    /// Unique ID for the custom report run object.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// The percentage completed of this custom report run. Valid values from 0-100, inclusive.
    /// </summary>
    [JsonPropertyName("percentComplete")]
    public required long PercentComplete { get; set; }

    /// <summary>
    /// The start time of the custom report run in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("startTime")]
    public required DateTime StartTime { get; set; }

    /// <summary>
    /// The status of the custom report run.  Valid values: `completed`, `pending`, `failed`, `cancelled`
    /// </summary>
    [JsonPropertyName("status")]
    public required GetCustomReportRunObjectResponseBodyStatus Status { get; set; }

    /// <summary>
    /// The optional array of tag ids to filter the custom report run by.
    /// </summary>
    [JsonPropertyName("tagIds")]
    public IEnumerable<string>? TagIds { get; set; }

    /// <summary>
    /// Time of when the custom report run was last updated in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("updatedAtTime")]
    public required DateTime UpdatedAtTime { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
