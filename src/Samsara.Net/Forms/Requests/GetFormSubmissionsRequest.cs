using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Forms;

[Serializable]
public record GetFormSubmissionsRequest
{
    /// <summary>
    /// A comma-separated list containing up to 100 form submission IDs to filter on. Can be either a unique Samsara ID or an [external ID](/docs/external-ids) for the form submission.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> Ids { get; set; } = new List<string>();

    /// <summary>
    /// A comma-separated list of strings indicating whether to return additional information. Valid values: `externalIds`
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> Include { get; set; } = new List<string>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
