using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record DvirDefectStreamDefectsResponseBody
{
    /// <summary>
    /// List of DVIR defects.
    /// </summary>
    [JsonPropertyName("data")]
    public IEnumerable<DefectsResponseDataResponseBody> Data { get; set; } =
        new List<DefectsResponseDataResponseBody>();

    [JsonPropertyName("pagination")]
    public required GoaPaginationResponseResponseBody Pagination { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
