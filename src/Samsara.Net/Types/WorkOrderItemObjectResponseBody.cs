using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Work Order Related Item object.
/// </summary>
[Serializable]
public record WorkOrderItemObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// ID of the item.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// The type of item.  Valid values: `DVIR`, `FAULT`, `FORM`, `ISSUE`, `ITEM_TYPE_UNSPECIFIED`, `MAINTENANCE_PREDICTION_EVENT`, `SCHEDULED_MAINTENANCE`
    /// </summary>
    [JsonPropertyName("type")]
    public required WorkOrderItemObjectResponseBodyType Type { get; set; }

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
