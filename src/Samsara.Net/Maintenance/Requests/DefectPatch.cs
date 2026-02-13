using System.Text.Json.Serialization;
using Samsara.Net;
using Samsara.Net.Core;

namespace Samsara.Net.Maintenance;

[Serializable]
public record DefectPatch
{
    /// <summary>
    /// Resolves the defect. Must be `true`.
    /// </summary>
    [JsonPropertyName("isResolved")]
    public bool? IsResolved { get; set; }

    /// <summary>
    /// The mechanics notes on the defect.
    /// </summary>
    [JsonPropertyName("mechanicNotes")]
    public string? MechanicNotes { get; set; }

    /// <summary>
    /// Time when defect was resolved. Defaults to now if not provided. UTC timestamp in RFC 3339 format. Example: `2020-01-27T07:06:25Z`.
    /// </summary>
    [JsonPropertyName("resolvedAtTime")]
    public string? ResolvedAtTime { get; set; }

    [JsonPropertyName("resolvedBy")]
    public ResolvedBy? ResolvedBy { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
