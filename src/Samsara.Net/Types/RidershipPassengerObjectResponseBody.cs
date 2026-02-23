using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// A ridership passenger entity.
/// </summary>
[Serializable]
public record RidershipPassengerObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The Samsara UUID of the account this passenger belongs to.
    /// </summary>
    [JsonPropertyName("accountId")]
    public required string AccountId { get; set; }

    /// <summary>
    /// Classification or grade level of the passenger.
    /// </summary>
    [JsonPropertyName("classification")]
    public string? Classification { get; set; }

    /// <summary>
    /// The time the passenger was created in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("createdAtTime")]
    public required string CreatedAtTime { get; set; }

    /// <summary>
    /// A map of external ids
    /// </summary>
    [JsonPropertyName("externalIds")]
    public Dictionary<string, string>? ExternalIds { get; set; }

    /// <summary>
    /// First name of the passenger.
    /// </summary>
    [JsonPropertyName("firstName")]
    public required string FirstName { get; set; }

    /// <summary>
    /// The unique Samsara ID of the passenger.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// List of identifiers associated with the passenger.
    /// </summary>
    [JsonPropertyName("identifiers")]
    public IEnumerable<RidershipPassengerIdentifierObjectResponseBody>? Identifiers { get; set; }

    /// <summary>
    /// Whether the passenger is active.
    /// </summary>
    [JsonPropertyName("isActive")]
    public required bool IsActive { get; set; }

    /// <summary>
    /// Last name of the passenger.
    /// </summary>
    [JsonPropertyName("lastName")]
    public required string LastName { get; set; }

    [JsonPropertyName("specialInstructions")]
    public RidershipPassengerSpecialInstructionsObjectResponseBody? SpecialInstructions { get; set; }

    /// <summary>
    /// The time the passenger was last updated in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("updatedAtTime")]
    public required string UpdatedAtTime { get; set; }

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
