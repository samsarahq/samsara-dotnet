using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[Serializable]
public record GetVoiceSessionsStreamRequest
{
    /// <summary>
    /// Lower bound on session start time, in RFC 3339 format. Millisecond precision and timezones are supported. (Examples: 2026-05-19T14:23:11Z, 2026-05-19T14:23:11.455Z, OR 2026-05-19T10:23:11-04:00).
    /// </summary>
    [JsonIgnore]
    public required string StartTime { get; set; }

    /// <summary>
    /// Upper bound on session start time, in RFC 3339 format. Defaults to the current time when omitted. Millisecond precision and timezones are supported.
    /// </summary>
    [JsonIgnore]
    public string? EndTime { get; set; }

    /// <summary>
    /// Required, comma-separated list of Agent Studio agent IDs to filter sessions on. Up to 100 agent IDs per call.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> AgentIds { get; set; } = new List<string>();

    /// <summary>
    /// Optional, comma-separated list of vehicle IDs. When set, only sessions whose target device was associated with one of these vehicles are returned. Up to 100 vehicle IDs per call.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> VehicleIds { get; set; } = new List<string>();

    /// <summary>
    /// Optional, comma-separated list of driver IDs. When set, only sessions whose target device was associated with one of these drivers are returned. Up to 100 driver IDs per call.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> DriverIds { get; set; } = new List<string>();

    /// <summary>
    /// Optional, comma-separated list of session statuses to filter on. Valid values: `completed`, `running`, `failed`, `unknown`. Defaults to `completed` when omitted.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> SessionStatus { get; set; } = new List<string>();

    /// <summary>
    /// If specified, this should be the endCursor value from the previous page of results. When present, this request will return the next page of results that occur immediately after the previous page of results.
    /// </summary>
    [JsonIgnore]
    public string? After { get; set; }

    /// <summary>
    /// Maximum number of sessions to return. Default 50, max 100.
    /// </summary>
    [JsonIgnore]
    public long? Limit { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
