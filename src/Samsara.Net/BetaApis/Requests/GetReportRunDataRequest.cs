using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApis;

[Serializable]
public record GetReportRunDataRequest
{
    /// <summary>
    /// ID of the report run.
    /// </summary>
    [JsonIgnore]
    public required string Id { get; set; }

    /// <summary>
    /// If specified, this should be the endCursor value from the previous page of results. When present, this request will return the next page of results that occur immediately after the previous page of results.
    /// </summary>
    [JsonIgnore]
    public string? After { get; set; }

    /// <summary>
    /// Maximum number of rows to return.
    /// </summary>
    [JsonIgnore]
    public long? Limit { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
