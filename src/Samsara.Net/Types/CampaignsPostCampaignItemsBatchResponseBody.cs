using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[Serializable]
public record CampaignsPostCampaignItemsBatchResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// UUID for this batch request; used when reaching out to support.
    /// </summary>
    [JsonPropertyName("requestId")]
    public required string RequestId { get; set; }

    /// <summary>
    /// One result per entry, in request order.
    /// </summary>
    [JsonPropertyName("responses")]
    public IEnumerable<CampaignItemIngestResponseItemObjectResponseBody> Responses { get; set; } =
        new List<CampaignItemIngestResponseItemObjectResponseBody>();

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
