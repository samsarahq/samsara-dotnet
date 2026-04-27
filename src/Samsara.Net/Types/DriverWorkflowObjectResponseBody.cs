using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// A driver app workflow configured for the organization.
/// </summary>
[Serializable]
public record DriverWorkflowObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The unique identifier of the workflow. Use this value when referring to the workflow from other APIs (e.g. driver create/update or driver workflow assignment).
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// The name of the workflow as configured by the organization.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// The type of workflow. Indicates which point in the driver's day the workflow is triggered at.  Valid values: `startOfDay`, `endOfDay`, `assetSelection`, `leaveAsset`, `ridershipSafetyCheck`, `stopArrival`
    /// </summary>
    [JsonPropertyName("workflowType")]
    public required DriverWorkflowObjectResponseBodyWorkflowType WorkflowType { get; set; }

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
