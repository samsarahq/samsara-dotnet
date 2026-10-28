using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Outcome for one entry of the request.
/// </summary>
[Serializable]
public record CampaignItemIngestResponseItemObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// ID of the asset the entry resolved to, when it resolved.
    /// </summary>
    [JsonPropertyName("assetId")]
    public string? AssetId { get; set; }

    /// <summary>
    /// Explanation for an entry that did not result in an item.
    /// </summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>
    /// Outcome of the entry. `alreadyPresent` means the asset already has an item on the campaign, in any state including `dismissed`; the existing item is left untouched, so a retried request is safe.  Valid values: `created`, `alreadyPresent`, `unresolvedVin`, `unresolvedAssetId`, `invalid`, `overCap`
    /// </summary>
    [JsonPropertyName("result")]
    public required CampaignItemIngestResponseItemObjectResponseBodyResult Result { get; set; }

    /// <summary>
    /// HTTP status for this entry: 200 for `created` and `alreadyPresent`, 400 for `invalid`, 404 for `unresolvedVin` and `unresolvedAssetId`, 409 for `overCap`.
    /// </summary>
    [JsonPropertyName("status")]
    public required long Status { get; set; }

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
