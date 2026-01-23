using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// A location. Polygon and Circle is deprecated, but may be set for old Alerts. At least one location must be selected.
/// </summary>
[Serializable]
public record LocationObjectRequestBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// All locations with selected address IDs will trigger.
    /// </summary>
    [JsonPropertyName("addressIds")]
    public IEnumerable<string>? AddressIds { get; set; }

    /// <summary>
    /// All locations with the selected address types will trigger.
    /// </summary>
    [JsonPropertyName("addressTypes")]
    public IEnumerable<LocationObjectRequestBodyAddressTypesItem>? AddressTypes { get; set; }

    [JsonPropertyName("circle")]
    public CircleRequestBody? Circle { get; set; }

    [JsonPropertyName("polygon")]
    public PolygonRequestBody? Polygon { get; set; }

    /// <summary>
    /// All locations with selected tag will trigger.
    /// </summary>
    [JsonPropertyName("tagIds")]
    public IEnumerable<string>? TagIds { get; set; }

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
