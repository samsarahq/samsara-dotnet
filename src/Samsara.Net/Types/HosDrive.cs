using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Remaining durations for the HOS driving shift limits.
/// </summary>
[Serializable]
public record HosDrive : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Remaining driving time the driver has in the current shift in milliseconds. For property-carrying drivers, this is the amount of time the driver can drive before hitting the 11-hour limit.
    /// </summary>
    [JsonPropertyName("driveRemainingDurationMs")]
    public double? DriveRemainingDurationMs { get; set; }

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
