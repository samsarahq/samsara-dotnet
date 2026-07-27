using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[Serializable]
public record ListPartInventoryRequest
{
    /// <summary>
    /// A filter on the data based on this comma-separated list of Place ID values.
    /// </summary>
    [JsonIgnore]
    public string? PlaceIds { get; set; }

    /// <summary>
    /// A filter on the data based on Low stock. Whether the available quantity is greater than zero and at or below the reorder threshold.
    /// </summary>
    [JsonIgnore]
    public bool? IsLowStock { get; set; }

    /// <summary>
    /// A filter on the data based on this comma-separated list of Part ID values.
    /// </summary>
    [JsonIgnore]
    public string? PartSamsaraIds { get; set; }

    /// <summary>
    /// If specified, this should be the endCursor value from the previous page of results. When present, this request will return the next page of results that occur immediately after the previous page of results.
    /// </summary>
    [JsonIgnore]
    public string? After { get; set; }

    /// <summary>
    /// The limit for how many objects will be in the response. Default and max for this value is 200 objects.
    /// </summary>
    [JsonIgnore]
    public long? Limit { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
