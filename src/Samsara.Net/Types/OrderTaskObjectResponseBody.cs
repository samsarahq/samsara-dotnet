using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Order task object with detailed information
/// </summary>
[Serializable]
public record OrderTaskObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// List of custom properties for the order
    /// </summary>
    [JsonPropertyName("customProperties")]
    public IEnumerable<OrderTaskCustomPropertyObjectResponseBody>? CustomProperties { get; set; }

    /// <summary>
    /// The order identifier
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// List of quantity information for the order
    /// </summary>
    [JsonPropertyName("quantities")]
    public IEnumerable<QuantityObjectResponseBody>? Quantities { get; set; }

    /// <summary>
    /// List of required skills for the order
    /// </summary>
    [JsonPropertyName("requiredSkills")]
    public IEnumerable<OrderTaskSkillObjectResponseBody>? RequiredSkills { get; set; }

    /// <summary>
    /// The service window time range
    /// </summary>
    [JsonPropertyName("serviceWindow")]
    public string? ServiceWindow { get; set; }

    /// <summary>
    /// The task type (pickup or delivery)
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }

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
