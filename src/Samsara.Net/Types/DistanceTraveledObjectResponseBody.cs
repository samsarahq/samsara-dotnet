using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

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

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
