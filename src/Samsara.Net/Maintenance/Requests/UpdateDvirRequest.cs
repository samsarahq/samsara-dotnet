using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Maintenance;

public record UpdateDvirRequest
{
    /// <summary>
    /// The user who is resolving the dvir.
    /// </summary>
    [JsonPropertyName("authorId")]
    public required string AuthorId { get; set; }

    /// <summary>
    /// Resolves the DVIR. Must be `true`.
    /// </summary>
    [JsonPropertyName("isResolved")]
    public required bool IsResolved { get; set; }

    /// <summary>
    /// The mechanics notes on the DVIR.
    /// </summary>
    [JsonPropertyName("mechanicNotes")]
    public string? MechanicNotes { get; set; }

    /// <summary>
    /// Time when user signed this DVIR. Defaults to now. UTC timestamp in RFC 3339 format. Example: `2020-01-27T07:06:25Z`.
    /// </summary>
    [JsonPropertyName("signedAtTime")]
    public string? SignedAtTime { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
