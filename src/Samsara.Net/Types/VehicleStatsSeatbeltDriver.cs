using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Seatbelt Driver Status as read from the vehicle. `Buckled` or `Unbuckled`.
/// </summary>
public record VehicleStatsSeatbeltDriver
{
    [JsonPropertyName("time")]
    public required string Time { get; set; }

    /// <summary>
    /// Seatbelt Driver Status as read from the vehicle. `Buckled` or `Unbuckled`.
    /// </summary>
    [JsonPropertyName("value")]
    public required VehicleStatsSeatbeltDriverValue Value { get; set; }

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
