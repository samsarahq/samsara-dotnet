using System.Text.Json.Serialization;
using Samsara.Net;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApis;

[Serializable]
public record PlanOrdersCreatePlanOrdersRequestBody
{
    /// <summary>
    /// An array of order objects to be created or updated
    /// </summary>
    [JsonPropertyName("data")]
    public IEnumerable<OrderInputObjectRequestBody> Data { get; set; } =
        new List<OrderInputObjectRequestBody>();

    /// <summary>
    /// Enable update of existing orders if an order with the same customerOrderId exists. The input must match the same quantity dimensions as the existing order. If not provided, requests will fail if an order's customerOrderId already exists.
    /// </summary>
    [JsonPropertyName("enableUpdateExistingOrders")]
    public bool? EnableUpdateExistingOrders { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
