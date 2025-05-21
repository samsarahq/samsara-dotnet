using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Preview;

public record PreviewGetFormTemplatesRequest
{
    /// <summary>
    /// A comma-separated list containing up to 100 template IDs to filter on.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> Ids { get; set; } = new List<string>();

    /// <summary>
    /// If specified, this should be the endCursor value from the previous page of results. When present, this request will return the next page of results that occur immediately after the previous page of results.
    /// </summary>
    [JsonIgnore]
    public string? After { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
