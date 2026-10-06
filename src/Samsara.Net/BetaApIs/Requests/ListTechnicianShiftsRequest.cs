using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[Serializable]
public record ListTechnicianShiftsRequest
{
    /// <summary>
    /// Up to 100 comma-separated shift identifiers.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> Ids { get; set; } = new List<string>();

    /// <summary>
    /// Up to 100 comma-separated user IDs.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> UserIds { get; set; } = new List<string>();

    /// <summary>
    /// Up to 100 comma-separated employee aliases.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> ExternalTechnicianIds { get; set; } = new List<string>();

    /// <summary>
    /// Inclusive updated-time lower bound.
    /// </summary>
    [JsonIgnore]
    public DateTime? StartTime { get; set; }

    /// <summary>
    /// Exclusive updated-time upper bound.
    /// </summary>
    [JsonIgnore]
    public DateTime? EndTime { get; set; }

    /// <summary>
    /// Cursor from the previous page.
    /// </summary>
    [JsonIgnore]
    public string? After { get; set; }

    /// <summary>
    /// Page size from 1 to 200; defaults to 200.
    /// </summary>
    [JsonIgnore]
    public long? Limit { get; set; }

    /// <summary>
    /// Include nonempty shift and technician external-ID maps. Defaults to false.
    /// </summary>
    [JsonIgnore]
    public bool? IncludeExternalIds { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
