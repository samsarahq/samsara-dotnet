using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[Serializable]
public record GetPlaceGeofenceRequest
{
    /// <summary>
    /// Seed point latitude in WGS84 decimal degrees.
    /// </summary>
    [JsonIgnore]
    public required double Latitude { get; set; }

    /// <summary>
    /// Seed point longitude in WGS84 decimal degrees.
    /// </summary>
    [JsonIgnore]
    public required double Longitude { get; set; }

    /// <summary>
    /// Comma-separated geofence suggestion types in priority order. Values: building, parcel, landUse, boundary, facility, infrastructure.
    /// </summary>
    [JsonIgnore]
    public string? SuggestionTypes { get; set; }

    /// <summary>
    /// Candidate sort order: smallestFirst (default) or largestFirst.  Valid values: `smallestFirst`, `largestFirst`
    /// </summary>
    [JsonIgnore]
    public GetPlaceGeofenceRequestSizeOrder? SizeOrder { get; set; }

    /// <summary>
    /// Search bound minimum latitude (WGS84 decimal degrees). Must be supplied with minLongitude, maxLatitude, and maxLongitude, or omitted entirely.
    /// </summary>
    [JsonIgnore]
    public double? MinLatitude { get; set; }

    /// <summary>
    /// Search bound minimum longitude (WGS84 decimal degrees).
    /// </summary>
    [JsonIgnore]
    public double? MinLongitude { get; set; }

    /// <summary>
    /// Search bound maximum latitude (WGS84 decimal degrees).
    /// </summary>
    [JsonIgnore]
    public double? MaxLatitude { get; set; }

    /// <summary>
    /// Search bound maximum longitude (WGS84 decimal degrees).
    /// </summary>
    [JsonIgnore]
    public double? MaxLongitude { get; set; }

    /// <summary>
    /// Drop candidates with area above this value in square meters.
    /// </summary>
    [JsonIgnore]
    public double? MaxAreaSquareMeters { get; set; }

    /// <summary>
    /// Drop candidates whose source polygon exceeds this vertex count before simplification.
    /// </summary>
    [JsonIgnore]
    public long? MaxSourceVertices { get; set; }

    /// <summary>
    /// Simplify each returned candidate polygon to at most this many vertices.
    /// </summary>
    [JsonIgnore]
    public long? MaxVertices { get; set; }

    /// <summary>
    /// Page size: max candidates in data[] per page. Default 5, max 20.
    /// </summary>
    [JsonIgnore]
    public long? MaxResults { get; set; }

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
