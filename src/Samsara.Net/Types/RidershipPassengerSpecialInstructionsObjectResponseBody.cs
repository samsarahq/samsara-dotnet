using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Special instructions for the passenger.
/// </summary>
[Serializable]
public record RidershipPassengerSpecialInstructionsObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Whether a guardian is required for the passenger.
    /// </summary>
    [JsonPropertyName("isGuardianRequired")]
    public bool? IsGuardianRequired { get; set; }

    /// <summary>
    /// Whether the passenger requires special education accommodations.
    /// </summary>
    [JsonPropertyName("isSpecialEducation")]
    public bool? IsSpecialEducation { get; set; }

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
