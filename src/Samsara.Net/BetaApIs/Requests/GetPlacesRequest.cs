using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[Serializable]
public record GetPlacesRequest
{
    /// <summary>
    /// If specified, this should be the endCursor value from the previous page of results. When present, this request will return the next page of results that occur immediately after the previous page of results.
    /// </summary>
    [JsonIgnore]
    public string? After { get; set; }

    /// <summary>
    /// The limit for how many objects will be in the response. Default and max for this value is 512 objects.
    /// </summary>
    [JsonIgnore]
    public long? Limit { get; set; }

    /// <summary>
    /// Comma-separated Samsara place IDs for batch lookup (max 100). When set, list filters and cursor pagination are ignored. External id tokens (key:value) are not supported in this version.
    /// </summary>
    [JsonIgnore]
    public string? PlaceIds { get; set; }

    /// <summary>
    /// Reserved. Batch lookup by external IDs is not implemented in this API version.
    /// </summary>
    [JsonIgnore]
    public string? ExternalIds { get; set; }

    /// <summary>
    /// When true, expands tag objects on each place. Defaults to false.
    /// </summary>
    [JsonIgnore]
    public bool? IncludeTags { get; set; }

    /// <summary>
    /// When true, includes externalIds on each place. Defaults to false.
    /// </summary>
    [JsonIgnore]
    public bool? IncludeExternalIds { get; set; }

    /// <summary>
    /// Comma-separated numeric tag IDs to filter places.
    /// </summary>
    [JsonIgnore]
    public string? TagIds { get; set; }

    /// <summary>
    /// Reserved. Filtering by parent tag IDs is not implemented in this API version.
    /// </summary>
    [JsonIgnore]
    public string? ParentTagIds { get; set; }

    /// <summary>
    /// Comma-separated place type tokens (e.g. yard,normalGeofence).
    /// </summary>
    [JsonIgnore]
    public string? PlaceTypes { get; set; }

    /// <summary>
    /// Filter places by name text.
    /// </summary>
    [JsonIgnore]
    public string? Name { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
