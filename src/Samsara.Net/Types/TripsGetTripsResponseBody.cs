using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record TripsGetTripsResponseBody
{
    /// <summary>
    /// List of trips
    /// </summary>
    [JsonPropertyName("data")]
    public IEnumerable<TripResponseBody> Data { get; set; } = new List<TripResponseBody>();

    [JsonPropertyName("pagination")]
    public required GoaPaginationResponseResponseBody Pagination { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
