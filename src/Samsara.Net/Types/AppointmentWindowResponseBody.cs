using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Appointment window
/// </summary>
[Serializable]
public record AppointmentWindowResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// End time of the appointment window, in RFC 3339 format
    /// </summary>
    [JsonPropertyName("endTime")]
    public required DateTime EndTime { get; set; }

    /// <summary>
    /// Start time of the appointment window, in RFC 3339 format
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
