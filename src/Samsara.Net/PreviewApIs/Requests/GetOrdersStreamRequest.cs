using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.PreviewApIs;

[Serializable]
public record GetOrdersStreamRequest
{
    /// <summary>
    /// Inclusive updatedAtTime lower bound in RFC 3339 format.
    /// </summary>
    [JsonIgnore]
    public required DateTime StartTime { get; set; }

    /// <summary>
    /// Exclusive updatedAtTime upper bound in RFC 3339 format.
    /// </summary>
    [JsonIgnore]
    public DateTime? EndTime { get; set; }

    /// <summary>
    /// Optional route ID scope.
    /// </summary>
    [JsonIgnore]
    public string? RouteId { get; set; }

    /// <summary>
    /// Include external IDs in returned orders.
    /// </summary>
    [JsonIgnore]
    public bool? IncludeExternalIds { get; set; }

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
