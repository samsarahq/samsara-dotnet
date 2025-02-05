using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record ContactTinyResponse
{
    /// <summary>
    /// First name of the contact.
    /// </summary>
    [JsonPropertyName("firstName")]
    public string? FirstName { get; set; }

    /// <summary>
    /// ID of the contact.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Last name of the contact.
    /// </summary>
    [JsonPropertyName("lastName")]
    public string? LastName { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
