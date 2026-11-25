using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// The electric charging purchase transaction that was created.
/// </summary>
[Serializable]
public record PostElectricPurchaseResponseBodyResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("discount")]
    public PostElectricPurchaseResponseBodyDiscountResponseBody? Discount { get; set; }

    /// <summary>
    /// Samsara ID of the driver.
    /// </summary>
    [JsonPropertyName("driverId")]
    public string? DriverId { get; set; }

    /// <summary>
    /// The amount of energy delivered in kilowatt hours.
    /// </summary>
    [JsonPropertyName("energyKilowattHours")]
    public required string EnergyKilowattHours { get; set; }

    /// <summary>
    /// Unique identifier for the electric purchase.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// Name of the charging network or operator.
    /// </summary>
    [JsonPropertyName("merchantName")]
    public string? MerchantName { get; set; }

    /// <summary>
    /// The integration provider.
    /// </summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>
    /// The street address or latitude/longitude of the charger.
    /// </summary>
    [JsonPropertyName("transactionLocation")]
    public required string TransactionLocation { get; set; }

    [JsonPropertyName("transactionPrice")]
    public required PostElectricPurchaseResponseBodyPriceResponseBody TransactionPrice { get; set; }

    /// <summary>
    /// The charging transaction reference.
    /// </summary>
    [JsonPropertyName("transactionReference")]
    public required string TransactionReference { get; set; }

    /// <summary>
    /// The time of the charging transaction in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("transactionTime")]
    public required string TransactionTime { get; set; }

    /// <summary>
    /// Samsara ID of the vehicle that was charged.
    /// </summary>
    [JsonPropertyName("vehicleId")]
    public string? VehicleId { get; set; }

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
