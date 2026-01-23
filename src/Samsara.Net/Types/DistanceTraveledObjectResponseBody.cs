using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// The distance traveled information of the log.
/// </summary>
[Serializable]
public record DistanceTraveledObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

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

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
