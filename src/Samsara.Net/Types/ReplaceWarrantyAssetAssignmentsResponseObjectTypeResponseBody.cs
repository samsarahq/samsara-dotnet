using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Response for the ReplaceWarrantyAssetAssignments action
/// </summary>
[Serializable]
public record ReplaceWarrantyAssetAssignmentsResponseObjectTypeResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The resulting asset assignments after the replace.
    /// </summary>
    [JsonPropertyName("data")]
    public IEnumerable<EntityReplaceWarrantyAssetAssignmentsWarrantyAssetAssignmentTypeResponseBody>? Data { get; set; }

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
