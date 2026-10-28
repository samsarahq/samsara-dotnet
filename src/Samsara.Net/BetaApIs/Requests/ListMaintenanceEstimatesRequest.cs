using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[Serializable]
public record ListMaintenanceEstimatesRequest
{
    /// <summary>
    /// Up to 100 comma-separated estimate identifiers.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> Ids { get; set; } = new List<string>();

    /// <summary>
    /// Up to 10 comma-separated numeric WO IDs. Bounds indexed-query fanout and authorization work.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> WorkOrderIds { get; set; } = new List<string>();

    /// <summary>
    /// Up to 10 comma-separated vendor-location identifiers; narrows the primary selection.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> VendorIds { get; set; } = new List<string>();

    /// <summary>
    /// Cursor returned by the preceding response; retain the same filters.
    /// </summary>
    [JsonIgnore]
    public string? After { get; set; }

    /// <summary>
    /// Include estimate external identifiers. Defaults to false.
    /// </summary>
    [JsonIgnore]
    public bool? IncludeExternalIds { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
