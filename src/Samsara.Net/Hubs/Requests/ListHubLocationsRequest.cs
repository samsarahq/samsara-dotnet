using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Hubs;

[Serializable]
public record ListHubLocationsRequest
{
    /// <summary>
    /// The hub identifier
    /// </summary>
    [JsonIgnore]
    public required string HubId { get; set; }

    /// <summary>
    /// A comma-separated list of location IDs that can be used for filtering
    /// </summary>
    [JsonIgnore]
    public string? LocationIds { get; set; }

    /// <summary>
    /// A comma-separated list of customer provided location IDs that can be used for filtering
    /// </summary>
    [JsonIgnore]
    public string? CustomerLocationIds { get; set; }

    /// <summary>
    /// Time filter of when the location was updated, in RFC 3339 format
    /// </summary>
    [JsonIgnore]
    public DateTime? StartTime { get; set; }

    /// <summary>
    /// Time filter of when the location was updated, in RFC 3339 format
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
