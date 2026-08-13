using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// EntityReplaceWarrantyAssetAssignmentsWarrantyAssetAssignmentInput object
/// </summary>
[Serializable]
public record EntityReplaceWarrantyAssetAssignmentsWarrantyAssetAssignmentInputTypeRequestBody
    : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// ID of the asset to assign.
    /// </summary>
    [JsonPropertyName("assetId")]
    public required string AssetId { get; set; }

    /// <summary>
    /// Asset engine hours at coverage start.
    /// </summary>
    [JsonPropertyName("startEngineHours")]
    public long? StartEngineHours { get; set; }

    /// <summary>
    /// Asset odometer reading at coverage start. Measured in meters.
    /// </summary>
    [JsonPropertyName("startOdometerMeters")]
    public long? StartOdometerMeters { get; set; }

    /// <summary>
    /// When coverage starts for this asset.
    /// </summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

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
