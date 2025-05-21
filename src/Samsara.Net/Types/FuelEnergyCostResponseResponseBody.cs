using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Estimated cost of fuel and energy over the given time range.
/// </summary>
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

    /// <summary>
    /// Additional properties received from the response, if any.
    /// </summary>
    /// <remarks>
    /// [EXPERIMENTAL] This API is experimental and may change in future releases.
    /// </remarks>
    [JsonExtensionData]
    public IDictionary<string, JsonElement> AdditionalProperties { get; internal set; } =
        new Dictionary<string, JsonElement>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
