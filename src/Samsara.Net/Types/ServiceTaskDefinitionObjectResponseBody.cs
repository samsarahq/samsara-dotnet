using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// A service task definition object.
/// </summary>
public record ServiceTaskDefinitionObjectResponseBody
{
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

    /// <summary>
    /// Additional properties received from the response, if any.
    /// </summary>
    /// <remarks>
    /// [EXPERIMENTAL] This API is experimental and may change in future releases.
    /// </remarks>
    [JsonExtensionData]
    public IDictionary<string, JsonElement> AdditionalProperties { get; internal set; } =
        new Dictionary<string, JsonElement>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
