using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// The start of a severe speeding event
/// </summary>
public record SevereSpeedingStartedObjectResponseBody
{
    /// <summary>
    /// The speeding start time in RFC 3339 format (Examples: 2019-06-13T19:08:25Z, 2019-06-13T19:08:25.455Z, OR 2015-09-15T14:00:12-04:00).
    /// </summary>
    [JsonPropertyName("startTime")]
    public required string StartTime { get; set; }

    /// <summary>
    /// The trip start time in RFC 3339 format (Examples: 2019-06-13T19:08:25Z, 2019-06-13T19:08:25.455Z, OR 2015-09-15T14:00:12-04:00).
    /// </summary>
    [JsonPropertyName("tripStartTime")]
    public string? TripStartTime { get; set; }

    [JsonPropertyName("vehicle")]
    public required VehicleResponseResponseBody Vehicle { get; set; }

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
