using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[Serializable]
public record ListPurchaseOrdersRequest
{
    /// <summary>
    /// A filter on the data based on this comma-separated list of ID values.
    /// </summary>
    [JsonIgnore]
    public string? Ids { get; set; }

    /// <summary>
    /// A filter on the data based on this comma-separated list of PO number values.
    /// </summary>
    [JsonIgnore]
    public string? PoNumbers { get; set; }

    /// <summary>
    /// A filter on the data based on this comma-separated list of Vendor values.
    /// </summary>
    [JsonIgnore]
    public string? VendorIds { get; set; }

    /// <summary>
    /// Optional end of the updated time range, exclusive. Defaults to the server's current time.
    /// </summary>
    [JsonIgnore]
    public string? EndTime { get; set; }

    /// <summary>
    /// Required start of the updated time range, inclusive.
    /// </summary>
    [JsonIgnore]
    public required string StartTime { get; set; }

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
