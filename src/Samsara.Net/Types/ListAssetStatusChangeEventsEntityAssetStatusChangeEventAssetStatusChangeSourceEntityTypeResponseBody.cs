using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// AssetStatusChangeSourceEntity object
/// </summary>
[Serializable]
public record ListAssetStatusChangeEventsEntityAssetStatusChangeEventAssetStatusChangeSourceEntityTypeResponseBody
    : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// ID of the record that triggered the change.
    /// </summary>
    [JsonPropertyName("sourceEntityId")]
    public string? SourceEntityId { get; set; }

    /// <summary>
    /// Kind of record that triggered the change.  Valid values: `unknown`, `workOrder`, `campaignItem`, `automationRule`, `geofence`, `dvir`, `csvUpload`
    /// </summary>
    [JsonPropertyName("sourceEntityType")]
    public ListAssetStatusChangeEventsEntityAssetStatusChangeEventAssetStatusChangeSourceEntityTypeResponseBodySourceEntityType? SourceEntityType { get; set; }

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
