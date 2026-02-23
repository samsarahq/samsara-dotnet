using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// An identifier (e.g., RFID tag) associated with the passenger.
/// </summary>
[Serializable]
public record RidershipPassengerIdentifierInputRequestBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The status of the identifier.  Valid values: `active`, `inactive`, `unknown`
    /// </summary>
    [JsonPropertyName("status")]
    public required RidershipPassengerIdentifierInputRequestBodyStatus Status { get; set; }

    /// <summary>
    /// The type of identifier.  Valid values: `rfid`, `unknown`
    /// </summary>
    [JsonPropertyName("type")]
    public required RidershipPassengerIdentifierInputRequestBodyType Type { get; set; }

    /// <summary>
    /// The identifier value.
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
