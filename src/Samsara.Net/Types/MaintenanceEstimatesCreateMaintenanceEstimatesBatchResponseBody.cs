using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[Serializable]
public record MaintenanceEstimatesCreateMaintenanceEstimatesBatchResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// UUID identifying this batch request.
    /// </summary>
    [JsonPropertyName("requestId")]
    public required string RequestId { get; set; }

    /// <summary>
    /// One outcome per input, in the same order. Successful writes remain committed when another item fails.
    /// </summary>
    [JsonPropertyName("responses")]
    public IEnumerable<MaintenanceEstimateBatchItemResponseResponseBody> Responses { get; set; } =
        new List<MaintenanceEstimateBatchItemResponseResponseBody>();

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
