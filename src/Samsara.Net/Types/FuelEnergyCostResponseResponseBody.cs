using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record FuelEnergyCostResponseResponseBody
{
    /// <summary>
    /// Amount of the currency.
    /// </summary>
    [JsonPropertyName("amount")]
    public required double Amount { get; set; }

    /// <summary>
    /// Type of the currency.
    /// </summary>
    [JsonPropertyName("currencyCode")]
    public required string CurrencyCode { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
