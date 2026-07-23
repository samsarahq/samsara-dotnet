using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[Serializable]
public record EquipmentOutputControlSetEquipmentDigitalOutputRequestBody
{
    /// <summary>
    /// The Samsara ID of the gateway whose digital output is being controlled. This must be an AG53 connected to powered equipment via the CBL-AG-BEQP cable.
    /// </summary>
    [JsonIgnore]
    public required long Id { get; set; }

    /// <summary>
    /// How long, in seconds, to hold the requested state before the device automatically reverts. Provide `0` (the default) to hold the state indefinitely. The maximum is 604800 seconds (7 days).
    /// </summary>
    [JsonPropertyName("durationSeconds")]
    public long? DurationSeconds { get; set; }

    /// <summary>
    /// The digital output pin to control. Only pin `1` is currently supported.
    /// </summary>
    [JsonPropertyName("pinId")]
    public required long PinId { get; set; }

    /// <summary>
    /// The desired output state. Provide `true` to energize the output, or `false` to de-energize it.
    /// </summary>
    [JsonPropertyName("state")]
    public required bool State { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
