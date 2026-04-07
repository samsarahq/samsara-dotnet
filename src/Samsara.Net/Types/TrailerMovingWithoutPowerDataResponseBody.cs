using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Details specific to Trailer Moving Without Power.
/// </summary>
[Serializable]
public record TrailerMovingWithoutPowerDataResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Voltage value from the trigger metadata when the alert fired.
    /// </summary>
    [JsonPropertyName("currentVoltage")]
    public int? CurrentVoltage { get; set; }

    [JsonPropertyName("driver")]
    public AlertObjectDriverResponseBody? Driver { get; set; }

    [JsonPropertyName("trailer")]
    public AlertObjectTrailerResponseBody? Trailer { get; set; }

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
