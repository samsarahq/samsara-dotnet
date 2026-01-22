using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Details specific to Harsh Events
/// </summary>
[Serializable]
public record HarshEventTriggerDetailsObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// On which harsh events to trigger on.
    /// </summary>
    [JsonPropertyName("types")]
    public IEnumerable<HarshEventTriggerDetailsObjectResponseBodyTypesItem> Types { get; set; } =
        new List<HarshEventTriggerDetailsObjectResponseBodyTypesItem>();

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
