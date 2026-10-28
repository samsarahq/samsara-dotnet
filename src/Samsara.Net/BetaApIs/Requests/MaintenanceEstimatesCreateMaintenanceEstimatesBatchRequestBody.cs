using System.Text.Json.Serialization;
using Samsara.Net;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[Serializable]
public record MaintenanceEstimatesCreateMaintenanceEstimatesBatchRequestBody
{
    /// <summary>
    /// Include estimate external identifiers. Defaults to false.
    /// </summary>
    [JsonIgnore]
    public bool? IncludeExternalIds { get; set; }

    /// <summary>
    /// Estimates to create, in response order. Maximum 10; an excess returns HTTP 413.
    /// </summary>
    [JsonPropertyName("estimates")]
    public IEnumerable<MaintenanceEstimateBatchCreateInputRequestBody> Estimates { get; set; } =
        new List<MaintenanceEstimateBatchCreateInputRequestBody>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
