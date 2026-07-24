using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[Serializable]
public record ListUpcomingPreventiveMaintenanceRequest
{
    /// <summary>
    /// A filter on the data based on this comma-separated list of Preventive maintenance schedule ID values.
    /// </summary>
    [JsonIgnore]
    public string? ScheduleIds { get; set; }

    /// <summary>
    /// A filter on the data based on this comma-separated list of Asset ID values.
    /// </summary>
    [JsonIgnore]
    public string? AssetIds { get; set; }

    /// <summary>
    /// If specified, this should be the endCursor value from the previous page of results. When present, this request will return the next page of results that occur immediately after the previous page of results.
    /// </summary>
    [JsonIgnore]
    public string? After { get; set; }

    /// <summary>
    /// The limit for how many objects will be in the response. Default and max for this value is 200 objects.
    /// </summary>
    [JsonIgnore]
    public long? Limit { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
