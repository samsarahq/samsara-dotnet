using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[Serializable]
public record OrdersPostOrdersBatchResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// UUID for this batch operation.
    /// </summary>
    [JsonPropertyName("requestId")]
    public required string RequestId { get; set; }

    /// <summary>
    /// One result per input order, in request order.
    /// </summary>
    [JsonPropertyName("responses")]
    public IEnumerable<FleetOrderBatchResponseItemResponseBody> Responses { get; set; } =
        new List<FleetOrderBatchResponseItemResponseBody>();

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
