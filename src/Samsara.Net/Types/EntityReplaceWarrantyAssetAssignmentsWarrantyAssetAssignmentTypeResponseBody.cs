using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// EntityReplaceWarrantyAssetAssignmentsWarrantyAssetAssignment object
/// </summary>
[Serializable]
public record EntityReplaceWarrantyAssetAssignmentsWarrantyAssetAssignmentTypeResponseBody
    : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// ID of the asset covered by the warranty.
    /// </summary>
    [JsonPropertyName("assetId")]
    public string? AssetId { get; set; }

    /// <summary>
    /// When the assignment was created.
    /// </summary>
    [JsonPropertyName("createdAtTime")]
    public string? CreatedAtTime { get; set; }

    /// <summary>
    /// Synthetic identifier for the assignment, formatted as "warrantyId:assetId".
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

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

    /// <summary>
    /// When the assignment was last updated.
    /// </summary>
    [JsonPropertyName("updatedAtTime")]
    public string? UpdatedAtTime { get; set; }

    /// <summary>
    /// ID of the warranty the asset is assigned to.
    /// </summary>
    [JsonPropertyName("warrantyId")]
    public string? WarrantyId { get; set; }

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
