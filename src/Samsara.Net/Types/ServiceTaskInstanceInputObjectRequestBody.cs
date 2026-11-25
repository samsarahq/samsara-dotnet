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
    /// Free-form technician notes for the service task.
    /// </summary>
    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    /// <summary>
    /// Parts for the service task.
    /// </summary>
    [JsonPropertyName("parts")]
    public IEnumerable<PartInstanceInputObjectRequestBody>? Parts { get; set; }

    [JsonPropertyName("partsCost")]
    public WorkOrderMoneyObjectRequestBody? PartsCost { get; set; }

    /// <summary>
    /// Complete stored procedure list for an existing service task, in the order GET returns procedures inside subtasks. That order sorts by rank. Omit to leave procedures unchanged. Each name must match the stored procedure at the same rank position. Names may repeat, so the match is positional. Only isCompleted is applied. Forms and procedure metadata are preserved, including the stored procedure order. Rejected when the service task has no stored procedures, including on create.
    /// </summary>
    [JsonPropertyName("procedures")]
    public IEnumerable<ServiceTaskProcedureInputObjectRequestBody>? Procedures { get; set; }

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
