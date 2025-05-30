using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Remaining durations and start time for the HOS on duty shift limits.
/// </summary>
public record HosShift
{
    /// <summary>
    /// Remaining on duty or driving time the driver in the current shift in milliseconds. For property-carrying drivers, this is the amount of time the driver can be on duty or driving before hitting the 14-hour limit.
    /// </summary>
    [JsonPropertyName("shiftRemainingDurationMs")]
    public double? ShiftRemainingDurationMs { get; set; }

    /// <summary>
    /// Additional properties received from the response, if any.
    /// </summary>
    /// <remarks>
    /// [EXPERIMENTAL] This API is experimental and may change in future releases.
    /// </remarks>
    [JsonExtensionData]
    public IDictionary<string, JsonElement> AdditionalProperties { get; internal set; } =
        new Dictionary<string, JsonElement>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
