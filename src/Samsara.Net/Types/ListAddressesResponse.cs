using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record ListAddressesResponse
{
    /// <summary>
    /// A list of Addresses.
    /// </summary>
    [JsonPropertyName("data")]
    public IEnumerable<Address> Data { get; set; } = new List<Address>();

    [JsonPropertyName("pagination")]
    public required PaginationResponse Pagination { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
