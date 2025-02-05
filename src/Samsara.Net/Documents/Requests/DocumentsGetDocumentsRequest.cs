using Samsara.Net.Core;

namespace Samsara.Net.Documents;

public record DocumentsGetDocumentsRequest
{
    /// <summary>
    /// A start time in RFC 3339 format. Defaults to now if not provided. Millisecond precision and timezones are supported. (Examples: 2019-06-13T19:08:25Z, 2019-06-13T19:08:25.455Z, OR 2015-09-15T14:00:12-04:00).
    /// </summary>
    public required string StartTime { get; set; }

    /// <summary>
    /// An end time in RFC 3339 format. Defaults to now if not provided. Millisecond precision and timezones are supported. (Examples: 2019-06-13T19:08:25Z, 2019-06-13T19:08:25.455Z, OR 2015-09-15T14:00:12-04:00).
    /// </summary>
    public required string EndTime { get; set; }

    /// <summary>
    /// If specified, this should be the endCursor value from the previous page of results. When present, this request will return the next page of results that occur immediately after the previous page of results.
    /// </summary>
    public string? After { get; set; }

    /// <summary>
    /// ID of the document template type.
    /// </summary>
    public string? DocumentTypeId { get; set; }

    /// <summary>
    /// Query by document creation time (`created`) or updated time (`updated`). Defaults to `created`.
    /// </summary>
    public string? QueryBy { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
