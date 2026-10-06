using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// An identifier used to recognize the passenger, such as an RFID card value. This is separate from the passenger's external IDs.
/// </summary>
[Serializable]
public record RidershipPassengerIdentifierInputRequestBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Whether the identifier is active or inactive. Defaults to `active`.  Valid values: `active`, `inactive`, `unknown`
    /// </summary>
    [JsonPropertyName("status")]
    public required RidershipPassengerIdentifierInputRequestBodyStatus Status { get; set; }

    /// <summary>
    /// The type of identifier.  Valid values: `rfid`, `unknown`
    /// </summary>
    [JsonPropertyName("type")]
    public required RidershipPassengerIdentifierInputRequestBodyType Type { get; set; }

    /// <summary>
    /// Value of the identifier, such as the value read from an RFID card.
    /// </summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }

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
