using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Work Order Service Task object.
/// </summary>
[Serializable]
public record ServiceTaskInstanceInputObjectRequestBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// ID of the service task instance. Only set if updating an existing service task instance.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("laborHourlyCost")]
    public WorkOrderMoneyObjectRequestBody? LaborHourlyCost { get; set; }

    /// <summary>
    /// The time of labor needed
    /// </summary>
    [JsonPropertyName("laborTimeMinutes")]
    public int? LaborTimeMinutes { get; set; }

    /// <summary>
    /// Parts for the service task.
    /// </summary>
    [JsonPropertyName("parts")]
    public IEnumerable<PartInstanceInputObjectRequestBody>? Parts { get; set; }

    [JsonPropertyName("partsCost")]
    public WorkOrderMoneyObjectRequestBody? PartsCost { get; set; }

    /// <summary>
    /// ID of the service task.
    /// </summary>
    [JsonPropertyName("serviceTaskId")]
    public required string ServiceTaskId { get; set; }

    /// <summary>
    /// The status of the service task.  Valid values: `Unknown`, `Open`, `In Progress`, `On Hold`, `Completed`
    /// </summary>
    [JsonPropertyName("status")]
    public required ServiceTaskInstanceInputObjectRequestBodyStatus Status { get; set; }

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
