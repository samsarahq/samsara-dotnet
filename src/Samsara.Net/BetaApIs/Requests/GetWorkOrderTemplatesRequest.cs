using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[Serializable]
public record GetWorkOrderTemplatesRequest
{
    /// <summary>
    /// The work order template IDs to look up. Up to 100 ids. Ids that do not resolve to a template (e.g. deleted) are omitted from the response.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> Ids { get; set; } = new List<string>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
