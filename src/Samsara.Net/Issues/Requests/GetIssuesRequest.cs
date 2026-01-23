using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Issues;

[Serializable]
public record GetIssuesRequest
{
    /// <summary>
    /// A comma-separated list containing up to 100 issue IDs to filter on. Can be either a unique Samsara ID or an [external ID](https://developers.samsara.com/docs/external-ids) for the issue.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> Ids { get; set; } = new List<string>();

    /// <summary>
    /// A comma separated list of additional fields to include on requested objects. Valid values: `externalIds`
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> Include { get; set; } = new List<string>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
