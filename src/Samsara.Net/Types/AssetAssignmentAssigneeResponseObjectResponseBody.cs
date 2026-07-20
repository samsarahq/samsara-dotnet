using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Assignee for an asset assignment.
/// </summary>
[Serializable]
public record AssetAssignmentAssigneeResponseObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Type of the assignee.  Valid values: `unknown`, `driver`, `asset`, `geofence`
    /// </summary>
    [JsonPropertyName("assigneeType")]
    public required AssetAssignmentAssigneeResponseObjectResponseBodyAssigneeType AssigneeType { get; set; }

    /// <summary>
    /// A map of external ids for the assignee.
    /// </summary>
    [JsonPropertyName("externalIds")]
    public Dictionary<string, string>? ExternalIds { get; set; }

    /// <summary>
    /// ID of the assignee.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

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
