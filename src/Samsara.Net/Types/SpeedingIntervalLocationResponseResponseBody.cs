using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Location object of the closest location point to the interval.
/// </summary>
[Serializable]
public record SpeedingIntervalLocationResponseResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Radial accuracy of gps location in meters. This will only return if strong GPS is not available.
    /// </summary>
    [JsonPropertyName("accuracyMeters")]
    public double? AccuracyMeters { get; set; }

    [JsonPropertyName("address")]
    public required AddressResponseResponseBody Address { get; set; }

    /// <summary>
    /// Heading of the asset in degrees. May be 0 if the asset is not moving.
    /// </summary>
    [JsonPropertyName("headingDegrees")]
    public required long HeadingDegrees { get; set; }

    /// <summary>
    /// Latitude of the closest location point to the interval.
    /// </summary>
    [JsonPropertyName("latitude")]
    public required double Latitude { get; set; }

    /// <summary>
    /// Longitude of the closest location point to the interval.
    /// </summary>
    [JsonPropertyName("longitude")]
    public required double Longitude { get; set; }

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
