using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// The digital output state that was successfully applied to the device.
/// </summary>
[Serializable]
public record SetEquipmentDigitalOutputDataResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The duration, in seconds, the state will be held. `0` means indefinitely.
    /// </summary>
    [JsonPropertyName("durationSeconds")]
    public required int DurationSeconds { get; set; }

    /// <summary>
    /// The Samsara ID of the gateway whose digital output was controlled.
    /// </summary>
    [JsonPropertyName("id")]
    public required long Id { get; set; }

    /// <summary>
    /// The digital output pin that was controlled.
    /// </summary>
    [JsonPropertyName("pinId")]
    public required int PinId { get; set; }

    /// <summary>
    /// The output state that was applied.
    /// </summary>
    [JsonPropertyName("state")]
    public required bool State { get; set; }

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
