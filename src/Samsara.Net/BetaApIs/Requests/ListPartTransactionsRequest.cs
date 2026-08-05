using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[Serializable]
public record ListPartTransactionsRequest
{
    /// <summary>
    /// A start time in RFC 3339 format. Millisecond precision and timezones are supported. (Examples: 2019-06-13T19:08:25Z, 2019-06-13T19:08:25.455Z, OR 2015-09-15T14:00:12-04:00).
    /// </summary>
    [JsonIgnore]
    public required string HappenedAtTimeStart { get; set; }

    /// <summary>
    /// An end time in RFC 3339 format. Millisecond precision and timezones are supported. (Examples: 2019-06-13T19:08:25Z, 2019-06-13T19:08:25.455Z, OR 2015-09-15T14:00:12-04:00).
    /// </summary>
    [JsonIgnore]
    public string? HappenedAtTimeEnd { get; set; }

    /// <summary>
    /// A filter on the data based on this comma-separated list of Part Samsara ID values.
    /// </summary>
    [JsonIgnore]
    public string? PartSamsaraIds { get; set; }

    /// <summary>
    /// A filter on the data based on this comma-separated list of Place ID values.
    /// </summary>
    [JsonIgnore]
    public string? PlaceIds { get; set; }

    /// <summary>
    /// A filter on the data based on this comma-separated list of Transaction Type values.
    /// </summary>
    [JsonIgnore]
    public string? TransactionTypeIn { get; set; }

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
