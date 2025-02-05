using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record ListUsersResponse
{
    /// <summary>
    /// A list of users.
    /// </summary>
    [JsonPropertyName("data")]
    public IEnumerable<User>? Data { get; set; }

    [JsonPropertyName("pagination")]
    public PaginationResponse? Pagination { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
