using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Navigation location.
/// </summary>
[Serializable]
public record PlaceNavigationLocationResponseResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Driver instructions.
    /// </summary>
    [JsonPropertyName("driverInstructions")]
    public string? DriverInstructions { get; set; }

    /// <summary>
    /// Latitude.
    /// </summary>
    [JsonPropertyName("latitude")]
    public required double Latitude { get; set; }

    /// <summary>
    /// Navigation location type.
    /// </summary>
    [JsonPropertyName("locationType")]
    public required string LocationType { get; set; }

    /// <summary>
    /// Longitude.
    /// </summary>
    [JsonPropertyName("longitude")]
    public required double Longitude { get; set; }

    /// <summary>
    /// Location name.
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
