using System.Text.Json.Serialization;
using Samsara.Net;
using Samsara.Net.Core;

namespace Samsara.Net.PreviewApIs;

[Serializable]
public record OrdersPostOrdersBatchRequestBody
{
    /// <summary>
    /// Orders to upsert atomically. Maximum 250.
    /// </summary>
    [JsonPropertyName("data")]
    public IEnumerable<FleetOrderBatchUpsertInputRequestBody> Data { get; set; } =
        new List<FleetOrderBatchUpsertInputRequestBody>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
