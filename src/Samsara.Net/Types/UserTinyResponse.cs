using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record UserTinyResponse
{
    /// <summary>
    /// ID of the user.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Name of the user.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
