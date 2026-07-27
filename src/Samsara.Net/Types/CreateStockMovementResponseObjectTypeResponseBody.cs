using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Response for the CreateStockMovement action
/// </summary>
[Serializable]
public record CreateStockMovementResponseObjectTypeResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("destinationLocation")]
    public EntityCreateStockMovementStockMovementLocationTypeResponseBody? DestinationLocation { get; set; }

    [JsonPropertyName("sourceLocation")]
    public EntityCreateStockMovementStockMovementLocationTypeResponseBody? SourceLocation { get; set; }

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
