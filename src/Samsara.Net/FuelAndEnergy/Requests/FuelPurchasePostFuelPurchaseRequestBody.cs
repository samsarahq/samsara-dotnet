using System.Text.Json.Serialization;
using Samsara.Net;
using Samsara.Net.Core;

namespace Samsara.Net.FuelAndEnergy;

public record FuelPurchasePostFuelPurchaseRequestBody
{
    /// <summary>
    /// The amount of fuel purchased in liters.
    /// </summary>
    [JsonPropertyName("fuelQuantityLiters")]
    public required string FuelQuantityLiters { get; set; }

    /// <summary>
    /// The type of fuel purchased supported by IFTA.  Valid values: `Unspecified`, `A55`, `Biodiesel`, `CompressedNaturalGas`, `Diesel`, `E85`, `Electricity`, `Ethanol`, `Gasohol`, `Gasoline`, `Hydrogen`, `LiquifiedNaturalGas`, `M85`, `Methanol`, `Propane`, `Other`
    /// </summary>
    [JsonPropertyName("iftaFuelType")]
    public FuelPurchasePostFuelPurchaseRequestBodyIftaFuelType? IftaFuelType { get; set; }

    /// <summary>
    /// The full street address for the location of the fuel transaction, as it might be recognized by Google Maps. Ideal entries should be in accordance with the format used by the national postal service of the country concerned (example: 1 De Haro St, San Francisco, CA 94107, United States). Alternatively, exact latitude/longitude can be provided (example: 40.748441, -73.985664).
    /// </summary>
    [JsonPropertyName("transactionLocation")]
    public required string TransactionLocation { get; set; }

    [JsonPropertyName("transactionPrice")]
    public required PostFuelPurchaseRequestBodyPriceRequestBody TransactionPrice { get; set; }

    /// <summary>
    /// The fuel transaction reference. This is the transaction identifier. For instance, this can be the Serial Number on the invoice.
    /// </summary>
    [JsonPropertyName("transactionReference")]
    public required string TransactionReference { get; set; }

    /// <summary>
    /// The time of the fuel transaction in RFC 3339 format. Timezone must be specified. For example, 2022-07-13T14:20:50.52-07:00 is a time in Pacific Daylight Time.
    /// </summary>
    [JsonPropertyName("transactionTime")]
    public required string TransactionTime { get; set; }

    /// <summary>
    /// Samsara ID of the vehicle that purchased the fuel.
    /// </summary>
    [JsonPropertyName("vehicleId")]
    public string? VehicleId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
