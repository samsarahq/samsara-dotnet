using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[Serializable]
public record FuelVolumeResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Units in which volume is being presented.  Valid values: `GALLONS`, `LITERS`
    /// </summary>
    [JsonPropertyName("unit")]
    public required FuelVolumeResponseBodyUnit Unit { get; set; }

    /// <summary>
    /// The volume of the measured fuel.
    /// </summary>
    [JsonPropertyName("value")]
    public required double Value { get; set; }

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
