using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

public record BetaApIsGetJobsRequest
{
    /// <summary>
    /// A jobId or uuid in STRING format. JobId must be prefixed with `jobId:`(Examples: `"8d218e6c-7a16-4f9f-90f7-cc1d93b9e596"`, `"jobId:98765"`).
    /// </summary>
    public string? Id { get; set; }

    /// <summary>
    /// A start time in RFC 3339 format. Millisecond precision and timezones are supported. (Examples: 2019-06-13T19:08:25Z, 2019-06-13T19:08:25.455Z, OR 2015-09-15T14:00:12-04:00).
    /// </summary>
    public string? StartDate { get; set; }

    /// <summary>
    /// An end time in RFC 3339 format. Millisecond precision and timezones are supported. (Examples: 2019-06-13T19:08:25Z, 2019-06-13T19:08:25.455Z, OR 2015-09-15T14:00:12-04:00).
    /// </summary>
    public string? EndDate { get; set; }

    /// <summary>
    /// IndustrialAssetId in STRING format. (Example: `"8d218e6c-7a16-4f9f-90f7-cc1d93b9e596"`).
    /// </summary>
    public IEnumerable<string> IndustrialAssetIds { get; set; } = new List<string>();

    /// <summary>
    /// FleetDeviceId in INTEGER format. (Example: `123456`).
    /// </summary>
    public IEnumerable<int> FleetDeviceIds { get; set; } = new List<int>();

    /// <summary>
    /// A job status in STRING format. Job statuses can be one of three (ignores case): `"active", "scheduled", "completed"`  Valid values: `active`, `scheduled`, `completed`
    /// </summary>
    public BetaApIsGetJobsRequestStatus? Status { get; set; }

    /// <summary>
    /// Customer name to filter by
    /// </summary>
    public string? CustomerName { get; set; }

    /// <summary>
    /// If specified, this should be the endCursor value from the previous page of results. When present, this request will return the next page of results that occur immediately after the previous page of results.
    /// </summary>
    public string? After { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
