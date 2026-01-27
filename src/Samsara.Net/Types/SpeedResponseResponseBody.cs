using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Speed object.
/// </summary>
[Serializable]
public record SpeedResponseResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Speed of asset based on ECU data.
    /// </summary>
    [JsonPropertyName("ecuSpeedMetersPerSecond")]
    public double? EcuSpeedMetersPerSecond { get; set; }

    /// <summary>
    /// Speed of asset based on GPS data.
    /// </summary>
    [JsonPropertyName("gpsSpeedMetersPerSecond")]
    public double? GpsSpeedMetersPerSecond { get; set; }

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
