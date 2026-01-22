using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// A service task definition object.
/// </summary>
[Serializable]
public record ServiceTaskDefinitionObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The category of the service task.
    /// </summary>
    [JsonPropertyName("category")]
    public string? Category { get; set; }

    /// <summary>
    /// A description of the service task.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Estimated time in minutes to complete the task.
    /// </summary>
    [JsonPropertyName("estimatedLaborTimeMinutes")]
    public int? EstimatedLaborTimeMinutes { get; set; }

    [JsonPropertyName("estimatedPartsCost")]
    public WorkOrderMoneyObjectResponseBody? EstimatedPartsCost { get; set; }

    /// <summary>
    /// The unique id of the service task definition.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// The name of the service task.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// The subcategory of the service task.
    /// </summary>
    [JsonPropertyName("subcategory")]
    public string? Subcategory { get; set; }

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
