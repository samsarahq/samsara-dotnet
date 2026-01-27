using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Gateways;

[Serializable]
public record GetGatewaysRequest
{
    /// <summary>
    /// Filter by a comma separated list of gateway models.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> Models { get; set; } = new List<string>();

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
