using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record HosEldEventsGetHosEldEventsResponseBody
{
    /// <summary>
    /// List of drivers and their ELD event objects data.
    /// </summary>
    [JsonPropertyName("data")]
    public IEnumerable<HosDriversEldEventObjectResponseBody> Data { get; set; } =
        new List<HosDriversEldEventObjectResponseBody>();

    [JsonPropertyName("pagination")]
    public GoaPaginationResponseResponseBody? Pagination { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
