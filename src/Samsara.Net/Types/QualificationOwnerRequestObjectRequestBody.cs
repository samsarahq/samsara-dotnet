using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Owner of the qualification record.
/// </summary>
[Serializable]
public record QualificationOwnerRequestObjectRequestBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Owner entity type  Valid values: `worker`, `asset`
    /// </summary>
    [JsonPropertyName("entityType")]
    public required QualificationOwnerRequestObjectRequestBodyEntityType EntityType { get; set; }

    /// <summary>
    /// ID of the owner (worker/asset)
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

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
