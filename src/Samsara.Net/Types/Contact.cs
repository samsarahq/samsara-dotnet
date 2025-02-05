using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record Contact
{
    [JsonPropertyName("email")]
    public required string Email { get; set; }

    [JsonPropertyName("firstName")]
    public required string FirstName { get; set; }

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("lastName")]
    public required string LastName { get; set; }

    [JsonPropertyName("phone")]
    public required string Phone { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
