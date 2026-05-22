using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// A customer-set price for a specific fuel type at this station.
/// </summary>
[Serializable]
public record PreferredStationPriceInputRequestBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The fuel type this price applies to.  Valid values: `gasoline`, `diesel`, `biodiesel`, `flexibleFuelE85`, `ethanolE100`, `renewableDiesel`, `m100`, `cng`, `lng`, `lpg`, `rng`, `fcev`, `unknown`
    /// </summary>
    [JsonPropertyName("fuelType")]
    public required PreferredStationPriceInputRequestBodyFuelType FuelType { get; set; }

    [JsonPropertyName("grossPrice")]
    public PreferredStationGrossPriceRequestBody? GrossPrice { get; set; }

    [JsonPropertyName("netPrice")]
    public PreferredStationNetPriceRequestBody? NetPrice { get; set; }

    /// <summary>
    /// Volume/energy unit.  Valid values: `liter`, `gallon`, `imperialGallon`
    /// </summary>
    [JsonPropertyName("volumeUnit")]
    public required PreferredStationPriceInputRequestBodyVolumeUnit VolumeUnit { get; set; }

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
