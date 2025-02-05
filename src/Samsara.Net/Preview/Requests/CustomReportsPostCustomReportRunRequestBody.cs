using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Preview;

public record CustomReportsPostCustomReportRunRequestBody
{
    /// <summary>
    /// The optional array of attribute value ids to filter the custom report run by.
    /// </summary>
    [JsonPropertyName("attributeValueIds")]
    public IEnumerable<string>? AttributeValueIds { get; set; }

    /// <summary>
    /// Required unique ID for the custom report linked to this run.
    /// </summary>
    [JsonPropertyName("customReportId")]
    public required string CustomReportId { get; set; }

    /// <summary>
    /// The end time of the custom report run in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("endTime")]
    public required DateTime EndTime { get; set; }

    /// <summary>
    /// The start time of the custom report run in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("startTime")]
    public required DateTime StartTime { get; set; }

    /// <summary>
    /// The optional array of tag ids to filter the custom report run by.
    /// </summary>
    [JsonPropertyName("tagIds")]
    public IEnumerable<long>? TagIds { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
