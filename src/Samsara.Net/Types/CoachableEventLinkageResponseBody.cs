using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Join key with upstream data source.
/// </summary>
[Serializable]
public record CoachableEventLinkageResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Unique identifier to the upstream data source. For safety events, this is the event uuid.
    /// </summary>
    [JsonPropertyName("sourceId")]
    public required string SourceId { get; set; }

    /// <summary>
    /// Upstream data source backing this coachable event.  Valid values: `triageEvent`, `hosViolation`, `idling`
    /// </summary>
    [JsonPropertyName("sourceType")]
    public required CoachableEventLinkageResponseBodySourceType SourceType { get; set; }

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
