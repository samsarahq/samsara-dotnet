using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Number of campaign items in one state.
/// </summary>
[Serializable]
public record CampaignItemStateCountResponseObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Number of items in the state.
    /// </summary>
    [JsonPropertyName("count")]
    public required long Count { get; set; }

    /// <summary>
    /// State of the counted items.  Valid values: `pending`, `hold`, `ready`, `workOrderCreated`, `complete`, `dismissed`, `cancelled`, `unknown`
    /// </summary>
    [JsonPropertyName("state")]
    public required CampaignItemStateCountResponseObjectResponseBodyState State { get; set; }

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
