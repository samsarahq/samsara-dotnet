using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record FuelPurchasePostFuelPurchaseResponseBody
{
    [JsonPropertyName("data")]
    public required PostFuelPurchaseResponseBodyResponseBody Data { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
