using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// The distance traveled information of the log.
/// </summary>
public record DistanceTraveledObjectResponseBody
{
    /// <summary>
    /// Distance driven in meters, rounded to two decimal places.
    /// </summary>
    [JsonPropertyName("driveDistanceMeters")]
    public long? DriveDistanceMeters { get; set; }

    /// <summary>
    /// Distance driven for personal conveyance, rounded to two decimal places.
    /// </summary>
    [JsonPropertyName("personalConveyanceDistanceMeters")]
    public long? PersonalConveyanceDistanceMeters { get; set; }

    /// <summary>
    /// Distance driven for yard moves, rounded to two decimal places.
    /// </summary>
    [JsonPropertyName("yardMoveDistanceMeters")]
    public long? YardMoveDistanceMeters { get; set; }

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
