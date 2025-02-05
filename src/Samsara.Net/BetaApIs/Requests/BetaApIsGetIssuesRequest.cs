using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

public record BetaApIsGetIssuesRequest
{
    /// <summary>
    /// A comma-separated list containing up to 100 issue IDs to filter on. Can be either a unique Samsara ID or an [external ID](https://developers.samsara.com/docs/external-ids) for the issue.
    /// </summary>
    public IEnumerable<string> Ids { get; set; } = new List<string>();

    /// <summary>
    /// A comma separated list of additional fields to include on requested objects. Valid values: `externalIds`
    /// </summary>
    public IEnumerable<string> Include { get; set; } = new List<string>();

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
