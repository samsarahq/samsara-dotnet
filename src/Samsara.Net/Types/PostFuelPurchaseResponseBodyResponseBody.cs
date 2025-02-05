using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record PostFuelPurchaseResponseBodyResponseBody
{
    /// <summary>
    /// Universally unique identifier for the fuel purchase.
    /// </summary>
    [JsonPropertyName("uuid")]
    public required string Uuid { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
