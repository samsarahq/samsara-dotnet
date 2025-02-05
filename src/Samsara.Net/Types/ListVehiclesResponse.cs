using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record ListVehiclesResponse
{
    [JsonPropertyName("data")]
    public IEnumerable<Vehicle> Data { get; set; } = new List<Vehicle>();

    [JsonPropertyName("pagination")]
    public required PaginationResponse Pagination { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
