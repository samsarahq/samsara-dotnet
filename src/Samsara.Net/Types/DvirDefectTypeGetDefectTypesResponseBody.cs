using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record DvirDefectTypeGetDefectTypesResponseBody
{
    /// <summary>
    /// List of defect types.
    /// </summary>
    [JsonPropertyName("data")]
    public IEnumerable<DefectTypesResponseDataResponseBody> Data { get; set; } =
        new List<DefectTypesResponseDataResponseBody>();

    [JsonPropertyName("pagination")]
    public required GoaPaginationResponseResponseBody Pagination { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
