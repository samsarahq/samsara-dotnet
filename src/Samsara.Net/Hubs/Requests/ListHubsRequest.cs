using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Hubs;

[Serializable]
public record ListHubsRequest
{
    /// <summary>
    /// A comma-separated list of hub IDs for filtering results.
    /// </summary>
    [JsonIgnore]
    public string? HubIds { get; set; }

    /// <summary>
    /// Returns hubs updated after the specified time in UTC
    /// </summary>
    [JsonIgnore]
    public DateTime? StartTime { get; set; }

    /// <summary>
    /// Returns hubs updated before the specified time in UTC
    /// </summary>
    [JsonIgnore]
    public DateTime? EndTime { get; set; }

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
