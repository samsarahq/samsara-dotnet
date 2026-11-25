using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// A recall that may affect your organization's assets based on make, model, and year.
/// </summary>
[Serializable]
public record RecallResponseObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// ID of the campaign created from this recall, if any.
    /// </summary>
    [JsonPropertyName("campaignId")]
    public string? CampaignId { get; set; }

    /// <summary>
    /// Affected component.
    /// </summary>
    [JsonPropertyName("component")]
    public required string Component { get; set; }

    /// <summary>
    /// Safety consequence of the defect.
    /// </summary>
    [JsonPropertyName("consequence")]
    public required string Consequence { get; set; }

    /// <summary>
    /// Reason given when the recall was last dismissed.
    /// </summary>
    [JsonPropertyName("dismissReason")]
    public string? DismissReason { get; set; }

    /// <summary>
    /// Time of the most recent dismissal, in RFC 3339 format. Remains set if the recall returns.
    /// </summary>
    [JsonPropertyName("dismissedAtTime")]
    public DateTime? DismissedAtTime { get; set; }

    /// <summary>
    /// Documents published by the recall source.
    /// </summary>
    [JsonPropertyName("documents")]
    public IEnumerable<RecallDocumentResponseObjectResponseBody> Documents { get; set; } =
        new List<RecallDocumentResponseObjectResponseBody>();

    /// <summary>
    /// Whether the source advises against driving affected vehicles. Defaults to false.
    /// </summary>
    [JsonPropertyName("hasDoNotDriveAdvisory")]
    public required bool HasDoNotDriveAdvisory { get; set; }

    /// <summary>
    /// Whether the source advises parking affected vehicles outside. Defaults to false.
    /// </summary>
    [JsonPropertyName("hasParkOutsideAdvisory")]
    public required bool HasParkOutsideAdvisory { get; set; }

    /// <summary>
    /// Unique ID of the recall. For NHTSA recalls, this is the campaign number.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// Whether `matchedAssetCount` exceeds `potentiallyAffectedUnitCount`. Defaults to false.
    /// </summary>
    [JsonPropertyName("isBroadMatch")]
    public required bool IsBroadMatch { get; set; }

    /// <summary>
    /// Whether your organization dismissed the recall. Defaults to false.
    /// </summary>
    [JsonPropertyName("isDismissed")]
    public required bool IsDismissed { get; set; }

    /// <summary>
    /// Whether the remedy is an over-the-air update. Defaults to false.
    /// </summary>
    [JsonPropertyName("isOverTheAirRemedy")]
    public required bool IsOverTheAirRemedy { get; set; }

    /// <summary>
    /// Whether an updated recall returned after dismissal. Defaults to false.
    /// </summary>
    [JsonPropertyName("isReturnedAfterDismissal")]
    public required bool IsReturnedAfterDismissal { get; set; }

    /// <summary>
    /// Manufacturer that filed the recall.
    /// </summary>
    [JsonPropertyName("manufacturer")]
    public required string Manufacturer { get; set; }

    /// <summary>
    /// Manufacturer's recall number.
    /// </summary>
    [JsonPropertyName("manufacturerRecallNumber")]
    public string? ManufacturerRecallNumber { get; set; }

    /// <summary>
    /// Number of your organization's assets matching the recall's make, model, and year.
    /// </summary>
    [JsonPropertyName("matchedAssetCount")]
    public required long MatchedAssetCount { get; set; }

    /// <summary>
    /// Total potentially affected units reported by the source, across all owners.
    /// </summary>
    [JsonPropertyName("potentiallyAffectedUnitCount")]
    public required long PotentiallyAffectedUnitCount { get; set; }

    /// <summary>
    /// Makes, models and years named by the recall.
    /// </summary>
    [JsonPropertyName("products")]
    public IEnumerable<RecallProductResponseObjectResponseBody> Products { get; set; } =
        new List<RecallProductResponseObjectResponseBody>();

    /// <summary>
    /// Source of the recall. Defaults to `unknown`.  Valid values: `recallMasters`, `nhtsa`, `oem`, `manual`, `api`, `unknown`
    /// </summary>
    [JsonPropertyName("recallSource")]
    public required RecallResponseObjectResponseBodyRecallSource RecallSource { get; set; }

    /// <summary>
    /// Corrective action described by the manufacturer.
    /// </summary>
    [JsonPropertyName("remedy")]
    public required string Remedy { get; set; }

    /// <summary>
    /// Date the source received the recall report, in RFC 3339 format. The time component is not used.
    /// </summary>
    [JsonPropertyName("reportTime")]
    public DateTime? ReportTime { get; set; }

    /// <summary>
    /// Link to the source's public recall page.
    /// </summary>
    [JsonPropertyName("sourceUrl")]
    public required string SourceUrl { get; set; }

    /// <summary>
    /// Title of the recall, when available.
    /// </summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; set; }

    /// <summary>
    /// Description of the defect.
    /// </summary>
    [JsonPropertyName("summary")]
    public required string Summary { get; set; }

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
