using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Order object
/// </summary>
[Serializable]
public record OrderObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The timestamp (in UTC) when the order was created
    /// </summary>
    [JsonPropertyName("createdAt")]
    public required DateTime CreatedAt { get; set; }

    /// <summary>
    /// An array of custom property values for the order
    /// </summary>
    [JsonPropertyName("customProperties")]
    public IEnumerable<OrderCustomPropertyResponseBody> CustomProperties { get; set; } =
        new List<OrderCustomPropertyResponseBody>();

    /// <summary>
    /// The customer-provided identifier for the order
    /// </summary>
    [JsonPropertyName("customerOrderId")]
    public required string CustomerOrderId { get; set; }

    [JsonPropertyName("delivery")]
    public OrderTaskResponseBody? Delivery { get; set; }

    /// <summary>
    /// The ID of the hub the order belongs to
    /// </summary>
    [JsonPropertyName("hubId")]
    public required string HubId { get; set; }

    /// <summary>
    /// The Samsara-generated unique identifier (UUID) for the order
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("pickup")]
    public OrderTaskResponseBody? Pickup { get; set; }

    /// <summary>
    /// The ID of the plan the order belongs to
    /// </summary>
    [JsonPropertyName("planId")]
    public required string PlanId { get; set; }

    /// <summary>
    /// Priority of the order (e.g., 1 for high, 5 for low)
    /// </summary>
    [JsonPropertyName("priority")]
    public required long Priority { get; set; }

    /// <summary>
    /// An array of quantities for the order
    /// </summary>
    [JsonPropertyName("quantities")]
    public IEnumerable<OrderQuantityResponseBody> Quantities { get; set; } =
        new List<OrderQuantityResponseBody>();

    /// <summary>
    /// An array of skill IDs required to fulfill the order
    /// </summary>
    [JsonPropertyName("skillsRequired")]
    public IEnumerable<string> SkillsRequired { get; set; } = new List<string>();

    /// <summary>
    /// The timestamp (in UTC) when the order was last updated
    /// </summary>
    [JsonPropertyName("updatedAt")]
    public required DateTime UpdatedAt { get; set; }

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
