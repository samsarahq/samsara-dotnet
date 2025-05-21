using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// The speed of the vehicle in miles per hour, as reported by the ECU.
/// </summary>
public record VehicleStatsEcuSpeedMphWithDecoration
{
    [JsonPropertyName("decorations")]
    public VehicleStatsDecorations? Decorations { get; set; }

    [JsonPropertyName("time")]
    public required string Time { get; set; }

    /// <summary>
    /// The speed of the vehicle in miles per hour.
    /// </summary>
    [JsonPropertyName("value")]
    public required double Value { get; set; }

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
