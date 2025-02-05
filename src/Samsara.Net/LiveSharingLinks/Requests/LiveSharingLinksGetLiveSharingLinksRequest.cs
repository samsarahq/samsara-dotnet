using Samsara.Net.Core;

namespace Samsara.Net.LiveSharingLinks;

public record LiveSharingLinksGetLiveSharingLinksRequest
{
    /// <summary>
    /// A filter on the data based on this comma-separated list of Live Share Link IDs
    /// </summary>
    public IEnumerable<string> Ids { get; set; } = new List<string>();

    /// <summary>
    /// A filter on the data based on the Live Sharing Link type.  Valid values: `all`, `assetsLocation`, `assetsNearLocation`, `assetsOnRoute`
    /// </summary>
    public LiveSharingLinksGetLiveSharingLinksRequestType? Type { get; set; }

    /// <summary>
    /// The limit for how many objects will be in the response. Default and max for this value is 100 objects.
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
