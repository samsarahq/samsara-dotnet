using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Data for auxiliary digio equipment.
/// </summary>
public record VehicleStatsAuxInput
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("time")]
    public string? Time { get; set; }

    /// <summary>
    /// Boolean indicating the state of the auxiliary equipment.
    /// </summary>
    [JsonPropertyName("value")]
    public bool? Value { get; set; }

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
