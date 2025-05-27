using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Remaining durations for the HOS driving shift limits.
/// </summary>
public record HosDrive
{
    /// <summary>
    /// Remaining driving time the driver has in the current shift in milliseconds. For property-carrying drivers, this is the amount of time the driver can drive before hitting the 11-hour limit.
    /// </summary>
    [JsonPropertyName("driveRemainingDurationMs")]
    public double? DriveRemainingDurationMs { get; set; }

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
