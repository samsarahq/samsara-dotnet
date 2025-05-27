using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Alerts.Incidents;

public record IncidentsStreamRequest
{
    /// <summary>
    /// Required RFC 3339 timestamp that indicates when to begin receiving data. This will be based on updatedAtTime.
    /// </summary>
    [JsonIgnore]
    public required string StartTime { get; set; }

    /// <summary>
    /// Required array of alert configuration ids to return incident data for.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> ConfigurationIds { get; set; } = new List<string>();

    /// <summary>
    /// Optional RFC 3339 timestamp to stop receiving data. Defaults to now if not provided. This will be based on updatedAtTime.
    /// </summary>
    [JsonIgnore]
    public string? EndTime { get; set; }

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
