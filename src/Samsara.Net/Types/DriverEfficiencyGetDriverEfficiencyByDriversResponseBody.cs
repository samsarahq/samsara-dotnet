using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record DriverEfficiencyGetDriverEfficiencyByDriversResponseBody
{
    /// <summary>
    /// List of driver efficiency data associated with drivers.
    /// </summary>
    [JsonPropertyName("data")]
    public IEnumerable<SingleDriverEfficiencyByDriverDataObjectResponseBody> Data { get; set; } =
        new List<SingleDriverEfficiencyByDriverDataObjectResponseBody>();

    [JsonPropertyName("pagination")]
    public required GoaPaginationResponseResponseBody Pagination { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
