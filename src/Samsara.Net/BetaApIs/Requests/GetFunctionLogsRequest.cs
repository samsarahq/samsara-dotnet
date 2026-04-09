using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[Serializable]
public record GetFunctionLogsRequest
{
    /// <summary>
    /// The name of the Function whose logs to retrieve.
    /// </summary>
    [JsonIgnore]
    public required string Name { get; set; }

    /// <summary>
    /// Required RFC 3339 timestamp for the beginning of the log time range.
    /// </summary>
    [JsonIgnore]
    public required DateTime StartTime { get; set; }

    /// <summary>
    /// Required RFC 3339 timestamp for the end of the log time range.
    /// </summary>
    [JsonIgnore]
    public required DateTime EndTime { get; set; }

    /// <summary>
    /// If specified, this should be the endCursor value from the previous page of results. When present, this request will return the next page of results that occur immediately after the previous page of results.
    /// </summary>
    [JsonIgnore]
    public string? After { get; set; }

    /// <summary>
    /// The maximum number of log entries to return per page. Default is 100.
    /// </summary>
    [JsonIgnore]
    public long? Limit { get; set; }

    /// <summary>
    /// Optional text to filter log entries. Only logs containing this text will be returned.
    /// </summary>
    [JsonIgnore]
    public string? FilterText { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
