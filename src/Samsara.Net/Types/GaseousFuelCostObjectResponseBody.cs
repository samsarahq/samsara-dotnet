using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// The cost incurred based on the gaseous fuel consumed during the idling event.
/// </summary>
public record GaseousFuelCostObjectResponseBody
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
    public required GaseousFuelCostObjectResponseBodyCurrency Currency { get; set; }

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
