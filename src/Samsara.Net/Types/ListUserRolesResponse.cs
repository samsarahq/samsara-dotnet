using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record ListUserRolesResponse
{
    /// <summary>
    /// A list of user roles
    /// </summary>
    [JsonPropertyName("data")]
    public IEnumerable<UserRole>? Data { get; set; }

    [JsonPropertyName("pagination")]
    public PaginationResponse? Pagination { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
