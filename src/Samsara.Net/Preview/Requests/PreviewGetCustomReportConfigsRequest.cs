using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Preview;

public record PreviewGetCustomReportConfigsRequest
{
    /// <summary>
    /// If specified, this should be the endCursor value from the previous page of results. When present, this request will return the next page of results that occur immediately after the previous page of results.
    /// </summary>
    [JsonIgnore]
    public string? After { get; set; }

    /// <summary>
    /// The limit for how many reports will be in the response. Default and max for this value is 100 objects.
    /// </summary>
    [JsonIgnore]
    public int? Limit { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
