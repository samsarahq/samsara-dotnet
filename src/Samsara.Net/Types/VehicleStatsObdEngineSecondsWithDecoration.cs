using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Vehicle OBD engine seconds reading.
/// </summary>
public record VehicleStatsObdEngineSecondsWithDecoration
{
    [JsonPropertyName("decorations")]
    public VehicleStatsDecorations? Decorations { get; set; }

    [JsonPropertyName("time")]
    public required string Time { get; set; }

    /// <summary>
    /// Number of seconds the vehicle's engine has been on according to the on-board diagnostics.
    /// </summary>
    [JsonPropertyName("value")]
    public required long Value { get; set; }

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
