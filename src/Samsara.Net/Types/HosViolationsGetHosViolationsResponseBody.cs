using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record HosViolationsGetHosViolationsResponseBody
{
    /// <summary>
    /// List of violations data
    /// </summary>
    [JsonPropertyName("data")]
    public IEnumerable<HosViolationsObjectResponseBody> Data { get; set; } =
        new List<HosViolationsObjectResponseBody>();

    [JsonPropertyName("pagination")]
    public required GoaPaginationResponseResponseBody Pagination { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
