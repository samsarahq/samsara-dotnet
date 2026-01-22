using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Tachograph activity
/// </summary>
[Serializable]
public record TachographActivity : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// End time of state in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("endTime")]
    public string? EndTime { get; set; }

    /// <summary>
    /// A flag indicating whether the activity was manually entered by the driver. If this is `true`, the state cannot be "UNKNOWN"
    /// </summary>
    [JsonPropertyName("isManualEntry")]
    public bool? IsManualEntry { get; set; }

    /// <summary>
    /// Start time of state in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary>
    /// Tachograph activity state. Valid values: `BREAK/REST`, `WORK`, `AVAILABILITY`, `DRIVING`, `UNKNOWN`.
    /// </summary>
    [JsonPropertyName("state")]
    public TachographActivityState? State { get; set; }

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
