using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Tire pressure readings for each of four tires in kilopascals.
/// </summary>
[Serializable]
public record VehicleStatsTirePressures : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The tire pressure of the rear left tire as seen when standing behind the vehicle in kilopascals.
    /// </summary>
    [JsonPropertyName("backLeftTirePressureKPa")]
    public long? BackLeftTirePressureKPa { get; set; }

    /// <summary>
    /// The tire pressure of the rear right tire as seen when standing behind the vehicle in kilopascals.
    /// </summary>
    [JsonPropertyName("backRightTirePressureKPa")]
    public long? BackRightTirePressureKPa { get; set; }

    /// <summary>
    /// The tire pressure of the front left tire as seen when standing behind the vehicle in kilopascals.
    /// </summary>
    [JsonPropertyName("frontLeftTirePressureKPa")]
    public long? FrontLeftTirePressureKPa { get; set; }

    /// <summary>
    /// The tire pressure of the front right tire as seen when standing behind the vehicle in kilopascals.
    /// </summary>
    [JsonPropertyName("frontRightTirePressureKPa")]
    public long? FrontRightTirePressureKPa { get; set; }

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
