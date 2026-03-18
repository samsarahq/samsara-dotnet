using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[Serializable]
public record SafetyEventsV2PatchSafetyEventsV2BatchResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Server-generated UUID for client-side correlation and logging. Not stored or queryable on the backend.
    /// </summary>
    [JsonPropertyName("requestId")]
    public required string RequestId { get; set; }

    /// <summary>
    /// One entry per requested safetyEventId, in the same order as the request.
    /// </summary>
    [JsonPropertyName("responses")]
    public IEnumerable<PatchSafetyEventsResponseItemResponseBody> Responses { get; set; } =
        new List<PatchSafetyEventsResponseItemResponseBody>();

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
