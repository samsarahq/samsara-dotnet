using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record PostFuelPurchaseRequestBodyPriceRequestBody
{
    /// <summary>
    /// The money amount.
    /// </summary>
    [JsonPropertyName("amount")]
    public required string Amount { get; set; }

    /// <summary>
    /// The currency of money. This is a 3-letter ISO 4217 currency code.  Valid values: `usd`, `gbp`, `cad`, `eur`, `chf`, `mxn`
    /// </summary>
    [JsonPropertyName("currency")]
    public required PostFuelPurchaseRequestBodyPriceRequestBodyCurrency Currency { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
