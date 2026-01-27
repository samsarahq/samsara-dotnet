using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Input object for creating orders
/// </summary>
[Serializable]
public record OrderInputObjectRequestBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// An array of custom property values for the order
    /// </summary>
    [JsonPropertyName("customProperties")]
    public IEnumerable<OrderCustomPropertyInputRequestBody>? CustomProperties { get; set; }

    /// <summary>
    /// The customer-provided identifier for the order
    /// </summary>
    [JsonPropertyName("customerOrderId")]
    public required string CustomerOrderId { get; set; }

    [JsonPropertyName("delivery")]
    public OrderTaskRequestBody? Delivery { get; set; }

    /// <summary>
    /// The ID of the hub the order belongs to
    /// </summary>
    [JsonPropertyName("hubId")]
    public required string HubId { get; set; }

    [JsonPropertyName("pickup")]
    public OrderTaskRequestBody? Pickup { get; set; }

    /// <summary>
    /// The ID of the plan the order belongs to
    /// </summary>
    [JsonPropertyName("planId")]
    public required string PlanId { get; set; }

    /// <summary>
    /// Priority of the order (e.g., 1 for high, 5 for low)
    /// </summary>
    [JsonPropertyName("priority")]
    public long? Priority { get; set; }

    /// <summary>
    /// An array of quantities for the order
    /// </summary>
    [JsonPropertyName("quantities")]
    public IEnumerable<OrderQuantityInputRequestBody>? Quantities { get; set; }

    /// <summary>
    /// An array of skill IDs required to fulfill the order
    /// </summary>
    [JsonPropertyName("skillsRequired")]
    public IEnumerable<string>? SkillsRequired { get; set; }

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
