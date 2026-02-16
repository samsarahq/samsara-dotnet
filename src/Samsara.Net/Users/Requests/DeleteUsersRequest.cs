using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Users;

[Serializable]
public record DeleteUsersRequest
{
    /// <summary>
    /// Unique identifier for the user.
    /// </summary>
    [JsonIgnore]
    public required string Id { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
