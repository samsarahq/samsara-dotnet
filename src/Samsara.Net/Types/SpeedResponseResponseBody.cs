using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Speed object.
/// </summary>
public record SpeedResponseResponseBody
{
    /// <summary>
    /// Speed of asset based on ECU data.
    /// </summary>
    [JsonPropertyName("ecuSpeedMetersPerSecond")]
    public double? EcuSpeedMetersPerSecond { get; set; }

    /// <summary>
    /// Speed of asset based on GPS data.
    /// </summary>
    [JsonPropertyName("gpsSpeedMetersPerSecond")]
    public double? GpsSpeedMetersPerSecond { get; set; }

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
