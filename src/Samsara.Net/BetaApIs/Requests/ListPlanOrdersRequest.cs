using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[Serializable]
public record ListPlanOrdersRequest
{
    /// <summary>
    /// The plan identifier
    /// </summary>
    [JsonIgnore]
    public required string PlanId { get; set; }

    /// <summary>
    /// Comma-separated list of order IDs for filtering.
    /// </summary>
    [JsonIgnore]
    public string? OrderIds { get; set; }

    /// <summary>
    /// If specified, should be the endCursor from the previous page of results. When present, this request will return the next page of results that occur immediately after the previous page of results.
    /// </summary>
    [JsonIgnore]
    public string? After { get; set; }

    /// <summary>
    /// Maximum number of objects to return. Default and maximum is 100
    /// </summary>
    [JsonIgnore]
    public long? Limit { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
