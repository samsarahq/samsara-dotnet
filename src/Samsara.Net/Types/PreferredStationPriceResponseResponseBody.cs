using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// A fuel price at the preferred fuel station.
/// </summary>
[Serializable]
public record PreferredStationPriceResponseResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The fuel type this price applies to.  Valid values: `gasoline`, `diesel`, `biodiesel`, `flexibleFuelE85`, `electricity`, `ethanolE100`, `renewableDiesel`, `m100`, `cng`, `lng`, `lpg`, `rng`, `fcev`, `unknown`
    /// </summary>
    [JsonPropertyName("fuelType")]
    public required PreferredStationPriceResponseResponseBodyFuelType FuelType { get; set; }

    [JsonPropertyName("grossPrice")]
    public PreferredStationGrossPriceResponseResponseBody? GrossPrice { get; set; }

    [JsonPropertyName("netPrice")]
    public PreferredStationNetPriceResponseResponseBody? NetPrice { get; set; }

    /// <summary>
    /// Volume/energy unit.  Valid values: `liter`, `gallon`, `imperialGallon`, `unknown`
    /// </summary>
    [JsonPropertyName("volumeUnit")]
    public required PreferredStationPriceResponseResponseBodyVolumeUnit VolumeUnit { get; set; }

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
