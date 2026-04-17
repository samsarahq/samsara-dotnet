using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[Serializable]
public record DeletePlanOrdersRequest
{
    /// <summary>
    /// The plan identifier
    /// </summary>
    [JsonIgnore]
    public required string PlanId { get; set; }

    /// <summary>
    /// Comma-separated list of order IDs to delete. Mutually exclusive with `deleteAll=true`; exactly one of the two must be provided.
    /// </summary>
    [JsonIgnore]
    public string? OrderIds { get; set; }

    /// <summary>
    /// When `true`, every order in the plan is deleted. Must not be combined with `orderIds`. Must be set to `true` explicitly — `false` is equivalent to omitting the parameter and requires `orderIds` to be supplied.
    /// </summary>
    [JsonIgnore]
    public bool? DeleteAll { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
