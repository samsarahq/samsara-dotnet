using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// A negotiated discount for a specific fuel type at this station.
/// </summary>
[Serializable]
public record PreferredStationDiscountInputRequestBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("discount")]
    public PreferredStationDiscountMoneyRequestBody? Discount { get; set; }

    /// <summary>
    /// The discount percentage. Used for percentage discount type.
    /// </summary>
    [JsonPropertyName("discountPercent")]
    public string? DiscountPercent { get; set; }

    /// <summary>
    /// How the discount is calculated.  Valid values: `centsPerUnit`, `percentage`, `fixedPrice`
    /// </summary>
    [JsonPropertyName("discountType")]
    public required PreferredStationDiscountInputRequestBodyDiscountType DiscountType { get; set; }

    /// <summary>
    /// The fuel type this discount applies to.  Valid values: `gasoline`, `diesel`, `biodiesel`, `flexibleFuelE85`, `ethanolE100`, `renewableDiesel`, `m100`, `cng`, `lng`, `lpg`, `rng`, `fcev`, `unknown`
    /// </summary>
    [JsonPropertyName("fuelType")]
    public required PreferredStationDiscountInputRequestBodyFuelType FuelType { get; set; }

    /// <summary>
    /// Volume/energy unit. Required for centsPerUnit and fixedPrice.  Valid values: `liter`, `gallon`, `imperialGallon`
    /// </summary>
    [JsonPropertyName("volumeUnit")]
    public PreferredStationDiscountInputRequestBodyVolumeUnit? VolumeUnit { get; set; }

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
