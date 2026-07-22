using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Shared asset response object.
/// </summary>
[Serializable]
public record SharedAssetResponseObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Time the shared asset was created, in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("createdAtTime")]
    public required string CreatedAtTime { get; set; }

    /// <summary>
    /// User ID who created the shared asset.
    /// </summary>
    [JsonPropertyName("createdByUserId")]
    public string? CreatedByUserId { get; set; }

    /// <summary>
    /// End time of the sharing period in RFC 3339 format. Null means indefinite sharing.
    /// </summary>
    [JsonPropertyName("endTime")]
    public string? EndTime { get; set; }

    /// <summary>
    /// Unique identifier for the shared asset.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// Asset ID in the provider organization.
    /// </summary>
    [JsonPropertyName("providerAssetId")]
    public required string ProviderAssetId { get; set; }

    /// <summary>
    /// Asset ID in the recipient organization. Only populated after asset is mirrored.
    /// </summary>
    [JsonPropertyName("recipientAssetId")]
    public string? RecipientAssetId { get; set; }

    /// <summary>
    /// The serial number of the shared asset.
    /// </summary>
    [JsonPropertyName("serial")]
    public required string Serial { get; set; }

    /// <summary>
    /// Start time of the sharing period in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("startTime")]
    public required string StartTime { get; set; }

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
