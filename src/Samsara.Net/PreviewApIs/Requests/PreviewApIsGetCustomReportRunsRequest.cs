using Samsara.Net.Core;

namespace Samsara.Net.PreviewApIs;

public record PreviewApIsGetCustomReportRunsRequest
{
    /// <summary>
    /// Required array of custom report IDs for the custom report runs wanted. Only one of customReportIds or ids is allowed.
    /// </summary>
    public IEnumerable<string> CustomReportIds { get; set; } = new List<string>();

    /// <summary>
    /// Required array of custom report run IDs to fetch. Only one of ids or customReportIds is allowed.
    /// </summary>
    public IEnumerable<string> Ids { get; set; } = new List<string>();

    /// <summary>
    /// If specified, this should be the endCursor value from the previous page of results. When present, this request will return the next page of results that occur immediately after the previous page of results.
    /// </summary>
    public string? After { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
