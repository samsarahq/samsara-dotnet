using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record UserRole
{
    /// <summary>
    /// The unique ID for the role.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// The name of the role.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
