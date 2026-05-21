using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Navigation location for a place.
/// </summary>
[Serializable]
public record PostPlaceNavigationLocationInputRequestBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Optional instructions for drivers.
    /// </summary>
    [JsonPropertyName("driverInstructions")]
    public string? DriverInstructions { get; set; }

    /// <summary>
    /// Latitude in decimal degrees.
    /// </summary>
    [JsonPropertyName("latitude")]
    public required double Latitude { get; set; }

    /// <summary>
    /// Navigation location type: entrance, exit, or twoWay.  Valid values: `entrance`, `exit`, `twoWay`
    /// </summary>
    [JsonPropertyName("locationType")]
    public required PostPlaceNavigationLocationInputRequestBodyLocationType LocationType { get; set; }

    /// <summary>
    /// Longitude in decimal degrees.
    /// </summary>
    [JsonPropertyName("longitude")]
    public required double Longitude { get; set; }

    /// <summary>
    /// Display name for the navigation location.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

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
