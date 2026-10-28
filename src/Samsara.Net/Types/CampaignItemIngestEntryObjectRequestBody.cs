using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// One asset to add to a campaign, identified by VIN, asset ID, or both.
/// </summary>
[Serializable]
public record CampaignItemIngestEntryObjectRequestBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// ID of the asset. Takes precedence over `vin` when both are given; the `vin` is then recorded on the item as provided. Required unless `vin` is given.
    /// </summary>
    [JsonPropertyName("assetId")]
    public string? AssetId { get; set; }

    /// <summary>
    /// Opaque reference to the row in your source feed, stored on the item for reconciliation.
    /// </summary>
    [JsonPropertyName("sourceRef")]
    public string? SourceRef { get; set; }

    /// <summary>
    /// VIN of the asset. Matched case-insensitively against the VINs of your organization's assets. Required unless `assetId` is given.
    /// </summary>
    [JsonPropertyName("vin")]
    public string? Vin { get; set; }

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
