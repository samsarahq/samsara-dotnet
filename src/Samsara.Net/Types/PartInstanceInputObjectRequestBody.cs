using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Work Order Part Instance object.
/// </summary>
[Serializable]
public record PartInstanceInputObjectRequestBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The cost of one unit of the part in cents. If not provided, the part defined cost will be used.
    /// </summary>
    [JsonPropertyName("costCentsOverride")]
    public long? CostCentsOverride { get; set; }

    /// <summary>
    /// ID of the part instance. Only set if updating an existing part instance.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// ID of the part definition.
    /// </summary>
    [JsonPropertyName("partId")]
    public required string PartId { get; set; }

    /// <summary>
    /// The quantity of the part in the parts pre defined unit of measure.
    /// </summary>
    [JsonPropertyName("quantity")]
    public required double Quantity { get; set; }

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
