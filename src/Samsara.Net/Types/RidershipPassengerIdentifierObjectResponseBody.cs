using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// An identifier used to recognize the passenger, such as an RFID card value.
/// </summary>
[Serializable]
public record RidershipPassengerIdentifierObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The unique Samsara ID of the identifier.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// Whether the identifier is active or inactive.  Valid values: `active`, `inactive`, `unknown`
    /// </summary>
    [JsonPropertyName("status")]
    public required RidershipPassengerIdentifierObjectResponseBodyStatus Status { get; set; }

    /// <summary>
    /// The type of identifier.  Valid values: `rfid`, `unknown`
    /// </summary>
    [JsonPropertyName("type")]
    public required RidershipPassengerIdentifierObjectResponseBodyType Type { get; set; }

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
