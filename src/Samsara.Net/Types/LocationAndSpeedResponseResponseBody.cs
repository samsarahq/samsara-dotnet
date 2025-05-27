using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Full location and speed objects.
/// </summary>
public record LocationAndSpeedResponseResponseBody
{
    [JsonPropertyName("asset")]
    public required AssetResponseResponseBody Asset { get; set; }

    /// <summary>
    /// UTC timestamp in RFC 3339 format of the event.
    /// </summary>
    [JsonPropertyName("happenedAtTime")]
    public required string HappenedAtTime { get; set; }

    [JsonPropertyName("location")]
    public required LocationResponseResponseBody Location { get; set; }

    [JsonPropertyName("speed")]
    public SpeedResponseResponseBody? Speed { get; set; }

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
