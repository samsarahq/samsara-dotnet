using Samsara.Net.Core;

namespace Samsara.Net.Webhooks;

public record WebhooksListRequest
{
    /// <summary>
    /// A filter on the data based on this comma-separated list of webhook IDs. Example: `ids=49412323223,49412329928`
    /// </summary>
    public string? Ids { get; set; }

    /// <summary>
    /// The limit for how many objects will be in the response. Default and max for this value is 512 objects.
    /// </summary>
    public int? Limit { get; set; }

    /// <summary>
    /// If specified, this should be the endCursor value from the previous page of results. When present, this request will return the next page of results that occur immediately after the previous page of results.
    /// </summary>
    public string? After { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
