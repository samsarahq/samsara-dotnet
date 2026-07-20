using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[Serializable]
public record GetFleetInstallerPhotoUploadsRequest
{
    /// <summary>
    /// Comma-separated list of upload session IDs to filter by. Max 100 IDs. When a single ID is provided and not found, returns 404. When multiple IDs are provided and any are not found, returns 400.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> Ids { get; set; } = new List<string>();

    /// <summary>
    /// A start time in RFC 3339 format. When provided, returns sessions where updatedAtTime &gt;= startTime. Omit to return sessions regardless of time. Combine with endTime for a bounded window.
    /// </summary>
    [JsonIgnore]
    public string? StartTime { get; set; }

    /// <summary>
    /// An end time in RFC 3339 format. Returns sessions where updatedAtTime &lt; endTime. Requires startTime — returns 400 if provided without startTime. Must be after startTime. Millisecond precision and timezones are supported. (Examples: 2026-06-13T19:08:25Z, 2026-06-13T19:08:25.455Z, OR 2026-06-13T14:00:12-04:00).
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
