using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Data for the engine immobilizer
/// </summary>
public record VehicleStatsEngineImmobilizerWithDecoration
{
    /// <summary>
    /// Whether the engine immobilizer is connected or not
    /// </summary>
    [JsonPropertyName("connected")]
    public required bool Connected { get; set; }

    [JsonPropertyName("decorations")]
    public VehicleStatsDecorations? Decorations { get; set; }

    /// <summary>
    /// The state of the engine immobilizer. Valid values: `ignition_disabled`, `ignition_enabled`. This stat type will only return states of our first Engine Immobilizer Hardware (ACC-EI). Please use &lt;a href="https://developers.samsara.com/reference/getengineimmobilizerstates" target="_blank"&gt;Get engine immobilizer states&lt;/a&gt; to get states for both Engine Immobilizer Hardware versions (incl. HW-EI21).
    /// </summary>
    [JsonPropertyName("state")]
    public required VehicleStatsEngineImmobilizerWithDecorationState State { get; set; }

    [JsonPropertyName("time")]
    public required string Time { get; set; }

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
