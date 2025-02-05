using Samsara.Net.Core;

namespace Samsara.Net.PreviewApIs;

public record PreviewApIsGetCustomReportRunDataRequest
{
    /// <summary>
    /// The ID of the specified run for the requested custom report.
    /// </summary>
    public string? Id { get; set; }

    /// <summary>
    /// If specified, this should be the endCursor value from the previous page of results. When present, this request will return the next page of results that occur immediately after the previous page of results.
    /// </summary>
    public string? After { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
