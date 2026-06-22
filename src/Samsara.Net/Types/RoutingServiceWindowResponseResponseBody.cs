using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Recurring service window for a routing row.
/// </summary>
[Serializable]
public record RoutingServiceWindowResponseResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Days this window applies.
    /// </summary>
    [JsonPropertyName("days")]
    public IEnumerable<string> Days { get; set; } = new List<string>();

    /// <summary>
    /// End time as HH:MM:SS in the org timezone.
    /// </summary>
    [JsonPropertyName("endTime")]
    public required string EndTime { get; set; }

    /// <summary>
    /// Start time as HH:MM:SS in the org timezone.
    /// </summary>
    [JsonPropertyName("startTime")]
    public required string StartTime { get; set; }

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
