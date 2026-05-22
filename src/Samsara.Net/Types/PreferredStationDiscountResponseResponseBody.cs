using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// A discount at the preferred fuel station.
/// </summary>
[Serializable]
public record PreferredStationDiscountResponseResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("discount")]
    public PreferredStationDiscountResponseMoneyResponseBody? Discount { get; set; }

    /// <summary>
    /// The discount percentage value.
    /// </summary>
    [JsonPropertyName("discountPercent")]
    public string? DiscountPercent { get; set; }

    /// <summary>
    /// How the discount is calculated.  Valid values: `centsPerUnit`, `percentage`, `fixedPrice`, `unknown`
    /// </summary>
    [JsonPropertyName("discountType")]
    public required PreferredStationDiscountResponseResponseBodyDiscountType DiscountType { get; set; }

    /// <summary>
    /// The fuel type this discount applies to.  Valid values: `gasoline`, `diesel`, `biodiesel`, `flexibleFuelE85`, `electricity`, `ethanolE100`, `renewableDiesel`, `m100`, `cng`, `lng`, `lpg`, `rng`, `fcev`, `unknown`
    /// </summary>
    [JsonPropertyName("fuelType")]
    public required PreferredStationDiscountResponseResponseBodyFuelType FuelType { get; set; }

    /// <summary>
    /// Volume/energy unit.  Valid values: `liter`, `gallon`, `imperialGallon`, `unknown`
    /// </summary>
    [JsonPropertyName("volumeUnit")]
    public PreferredStationDiscountResponseResponseBodyVolumeUnit? VolumeUnit { get; set; }

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
