using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[Serializable]
public record ListHubRouteTemplatesRequest
{
    /// <summary>
    /// The hub identifier.
    /// </summary>
    [JsonIgnore]
    public required string HubId { get; set; }

    /// <summary>
    /// Filter by a specific route template ID.
    /// </summary>
    [JsonIgnore]
    public string? Id { get; set; }

    /// <summary>
    /// Filter by route template name (exact match).
    /// </summary>
    [JsonIgnore]
    public string? Name { get; set; }

    /// <summary>
    /// If specified, this should be the endCursor value from the previous page of results. When present, this request will return the next page of results that occur immediately after the previous page of results.
    /// </summary>
    [JsonIgnore]
    public string? After { get; set; }

    /// <summary>
    /// The limit for how many objects will be in the response. Default and max for this value is 100 objects.
    /// </summary>
    [JsonIgnore]
    public long? Limit { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
