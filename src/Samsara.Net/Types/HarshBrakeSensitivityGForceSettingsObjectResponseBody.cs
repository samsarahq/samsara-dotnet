using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// The harsh brake sensitivity settings.
/// </summary>
[Serializable]
public record HarshBrakeSensitivityGForceSettingsObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Harsh brake sensitivity settings for heavy duty vehicle.
    /// </summary>
    [JsonPropertyName("heavyDuty")]
    public string? HeavyDuty { get; set; }

    /// <summary>
    /// Harsh brake sensitivity settings for light duty vehicle.
    /// </summary>
    [JsonPropertyName("lightDuty")]
    public string? LightDuty { get; set; }

    /// <summary>
    /// Harsh brake sensitivity settings for passenger car.
    /// </summary>
    [JsonPropertyName("passenger")]
    public string? Passenger { get; set; }

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
