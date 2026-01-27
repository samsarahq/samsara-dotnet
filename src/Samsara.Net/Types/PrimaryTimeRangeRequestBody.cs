using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Primary time range of the report that not all datasets and report configs support.
/// </summary>
[Serializable]
public record PrimaryTimeRangeRequestBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// End time of the time range filter in RFC3339 format.
    /// </summary>
    [JsonPropertyName("endTime")]
    public required DateTime EndTime { get; set; }

    /// <summary>
    /// Start time of the time range filter in RFC3339 format.
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
