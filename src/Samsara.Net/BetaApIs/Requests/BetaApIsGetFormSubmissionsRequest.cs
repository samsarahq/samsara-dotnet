using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

public record BetaApIsGetFormSubmissionsRequest
{
    /// <summary>
    /// A comma-separated list containing up to 100 form submission IDs to filter on. Can be either a unique Samsara ID or an [external ID](https://developers.samsara.com/docs/external-ids) for the form submission.
    /// </summary>
    public IEnumerable<string> Ids { get; set; } = new List<string>();

    /// <summary>
    /// A comma-separated list of strings indicating whether to return additional information. Valid values: `externalIds`, `fieldLabels`
    /// </summary>
    public IEnumerable<string> Include { get; set; } = new List<string>();

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
