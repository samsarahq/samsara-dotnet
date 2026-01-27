using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Media asset available for the safety event.
/// </summary>
[Serializable]
public record SafetyEventV2MediaResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The serial number of the auxiliary camera device.
    /// </summary>
    [JsonPropertyName("auxcamSerial")]
    public string? AuxcamSerial { get; set; }

    /// <summary>
    /// The currently assigned role name of the camera. May change if camera role settings are updated.  Valid values: `leftMirrorMount`, `leftSide`, `rightMirrorMount`, `rightSide`, `rearHigh`, `rearBumper`, `inCab`, `front`, `hopper`, `other1`, `other2`, `other3`, `other4`, `leftBev`, `rightBev`, `rearBev`, `frontBev`, `otherBev`, `bevNotUsed`
    /// </summary>
    [JsonPropertyName("cameraRole")]
    public SafetyEventV2MediaResponseBodyCameraRole? CameraRole { get; set; }

    /// <summary>
    /// The media input type of the camera.  Valid values: `dashcamRoadFacing`, `dashcamDriverFacing`, `analog1`, `analog2`, `analog3`, `analog4`
    /// </summary>
    [JsonPropertyName("input")]
    public required SafetyEventV2MediaResponseBodyInput Input { get; set; }

    /// <summary>
    /// URL to download the media asset.
    /// </summary>
    [JsonPropertyName("url")]
    public required string Url { get; set; }

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
