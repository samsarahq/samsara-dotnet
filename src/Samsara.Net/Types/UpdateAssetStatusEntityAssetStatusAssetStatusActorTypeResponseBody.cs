using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// AssetStatusActor object
/// </summary>
[Serializable]
public record UpdateAssetStatusEntityAssetStatusAssetStatusActorTypeResponseBody
    : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// ID of the user or API token that made the change. For system changes, a fixed label for the process.
    /// </summary>
    [JsonPropertyName("actorId")]
    public string? ActorId { get; set; }

    /// <summary>
    /// Whether a user, an API token, or Samsara itself made the change.  Valid values: `unknown`, `user`, `system`, `apiToken`
    /// </summary>
    [JsonPropertyName("actorType")]
    public UpdateAssetStatusEntityAssetStatusAssetStatusActorTypeResponseBodyActorType? ActorType { get; set; }

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
