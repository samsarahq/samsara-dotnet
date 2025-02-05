using Samsara.Net.Core;

namespace Samsara.Net.Tags;

public record TagsListTagsRequest
{
    /// <summary>
    /// The limit for how many objects will be in the response. Default and max for this value is 512 objects.
    /// </summary>
    public long? Limit { get; set; }

    /// <summary>
    /// If specified, this should be the endCursor value from the previous page of results. When present, this request will return the next page of results that occur immediately after the previous page of results.
    /// </summary>
    public string? After { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
