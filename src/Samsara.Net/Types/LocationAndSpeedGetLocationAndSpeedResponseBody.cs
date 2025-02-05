using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record LocationAndSpeedGetLocationAndSpeedResponseBody
{
    /// <summary>
    /// List of location and speed objects.
    /// </summary>
    [JsonPropertyName("data")]
    public IEnumerable<LocationAndSpeedResponseResponseBody> Data { get; set; } =
        new List<LocationAndSpeedResponseResponseBody>();

    [JsonPropertyName("pagination")]
    public required GoaPaginationWithTokensResponseResponseBody Pagination { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
