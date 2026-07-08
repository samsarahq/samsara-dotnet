using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Business contact information for a place.
/// </summary>
[Serializable]
public record PostPlaceBusinessContactsInputRequestBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Named contacts with optional phone and email.
    /// </summary>
    [JsonPropertyName("contacts")]
    public IEnumerable<PostPlaceBusinessContactInputRequestBody>? Contacts { get; set; }

    /// <summary>
    /// Place-level email addresses. Opaque strings; max 100 characters each.
    /// </summary>
    [JsonPropertyName("email")]
    public IEnumerable<string>? Email { get; set; }

    /// <summary>
    /// Place-level phone numbers. Opaque strings; max 15 characters each.
    /// </summary>
    [JsonPropertyName("phoneNumbers")]
    public IEnumerable<string>? PhoneNumbers { get; set; }

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
