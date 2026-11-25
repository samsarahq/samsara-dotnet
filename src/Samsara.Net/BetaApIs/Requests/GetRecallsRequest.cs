using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[Serializable]
public record GetRecallsRequest
{
    /// <summary>
    /// Comma-separated recall IDs. Maximum 100 unique IDs. Unknown IDs are omitted; returns 404 if none are found. Cannot be combined with `after`.
    /// </summary>
    [JsonIgnore]
    public string? Ids { get; set; }

    /// <summary>
    /// Return only dismissed recalls (`true`) or only possible matches (`false`). Returns both when omitted.
    /// </summary>
    [JsonIgnore]
    public bool? IsDismissed { get; set; }

    /// <summary>
    /// Filter by exact manufacturer name. Maximum 256 characters.
    /// </summary>
    [JsonIgnore]
    public string? Manufacturer { get; set; }

    /// <summary>
    /// Include recalls reported at or after this time, in RFC 3339 format.
    /// </summary>
    [JsonIgnore]
    public DateTime? ReportStartTime { get; set; }

    /// <summary>
    /// Include recalls reported before this time, in RFC 3339 format. Must be after `reportStartTime`.
    /// </summary>
    [JsonIgnore]
    public DateTime? ReportEndTime { get; set; }

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
