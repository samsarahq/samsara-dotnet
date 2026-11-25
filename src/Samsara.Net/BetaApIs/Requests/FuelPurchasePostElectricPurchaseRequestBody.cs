using System.Text.Json.Serialization;
using Samsara.Net;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[Serializable]
public record FuelPurchasePostElectricPurchaseRequestBody
{
    [JsonPropertyName("discount")]
    public PostElectricPurchaseRequestBodyDiscountRequestBody? Discount { get; set; }

    /// <summary>
    /// Samsara ID of the driver.
    /// </summary>
    [JsonPropertyName("driverId")]
    public string? DriverId { get; set; }

    /// <summary>
    /// The amount of energy delivered in kilowatt hours, as a decimal string greater than 0.
    /// </summary>
    [JsonPropertyName("energyKilowattHours")]
    public required string EnergyKilowattHours { get; set; }

    /// <summary>
    /// Name of the charging network or operator. For example: ChargePoint, Electrify America.
    /// </summary>
    [JsonPropertyName("merchantName")]
    public string? MerchantName { get; set; }

    /// <summary>
    /// The integration provider. For example: Customer, ChargePoint Integration
    /// </summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>
    /// The full street address of the charger, as it might be recognized by Google Maps (example: 1 De Haro St, San Francisco, CA 94107, United States). Alternatively, exact latitude/longitude can be provided (example: 40.748441, -73.985664).
    /// </summary>
    [JsonPropertyName("transactionLocation")]
    public required string TransactionLocation { get; set; }

    [JsonPropertyName("transactionPrice")]
    public required PostElectricPurchaseRequestBodyPriceRequestBody TransactionPrice { get; set; }

    /// <summary>
    /// The charging transaction reference. This is the transaction identifier, such as the receipt or charging session number.
    /// </summary>
    [JsonPropertyName("transactionReference")]
    public required string TransactionReference { get; set; }

    /// <summary>
    /// The time of the charging transaction in RFC 3339 format. Timezone must be specified. For example, 2022-07-13T14:20:50.52-07:00 is a time in Pacific Daylight Time.
    /// </summary>
    [JsonPropertyName("transactionTime")]
    public required string TransactionTime { get; set; }

    /// <summary>
    /// Samsara ID of the vehicle that was charged.
    /// </summary>
    [JsonPropertyName("vehicleId")]
    public string? VehicleId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
