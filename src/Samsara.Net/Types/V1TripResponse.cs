using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record V1TripResponse
{
    [JsonPropertyName("trips")]
    public IEnumerable<V1TripResponseTrips>? Trips { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
