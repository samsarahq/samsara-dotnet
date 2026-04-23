using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Asset assignment object.
/// </summary>
[Serializable]
public record AssetAssignmentResponseObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("asset")]
    public required AssetResponseResponseBody Asset { get; set; }

    [JsonPropertyName("assignee")]
    public required AssetAssignmentAssigneeResponseObjectResponseBody Assignee { get; set; }

    /// <summary>
    /// The end time of the assignment in RFC 3339 format, if the assignment has ended.
    /// </summary>
    [JsonPropertyName("endTime")]
    public DateTime? EndTime { get; set; }

    /// <summary>
    /// The start time of the assignment in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("startTime")]
    public required DateTime StartTime { get; set; }

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
