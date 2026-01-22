using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Contacts;

[Serializable]
public record UpdateContactRequest
{
    /// <summary>
    /// Unique identifier for the contact.
    /// </summary>
    [JsonIgnore]
    public required string Id { get; set; }

    /// <summary>
    /// Email address of the contact.
    /// </summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }

    /// <summary>
    /// First name of the contact.
    /// </summary>
    [JsonPropertyName("firstName")]
    public string? FirstName { get; set; }

    /// <summary>
    /// Last name of the contact.
    /// </summary>
    [JsonPropertyName("lastName")]
    public string? LastName { get; set; }

    /// <summary>
    /// Phone number of the contact.
    /// </summary>
    [JsonPropertyName("phone")]
    public string? Phone { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
