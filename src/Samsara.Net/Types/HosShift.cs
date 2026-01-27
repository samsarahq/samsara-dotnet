using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Remaining durations and start time for the HOS on duty shift limits.
/// </summary>
[Serializable]
public record HosShift : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Remaining on duty or driving time the driver in the current shift in milliseconds. For property-carrying drivers, this is the amount of time the driver can be on duty or driving before hitting the 14-hour limit.
    /// </summary>
    [JsonPropertyName("shiftRemainingDurationMs")]
    public double? ShiftRemainingDurationMs { get; set; }

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
