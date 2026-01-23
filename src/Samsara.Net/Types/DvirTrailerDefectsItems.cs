using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[Serializable]
public record DvirTrailerDefectsItems : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Comment on the defect.
    /// </summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary>
    /// Time when the defect was created. UTC timestamp in RFC 3339 format. Example: `2020-01-27T07:06:25Z`.
    /// </summary>
    [JsonPropertyName("createdAtTime")]
    public string? CreatedAtTime { get; set; }

    /// <summary>
    /// The type of DVIR defect.
    /// </summary>
    [JsonPropertyName("defectType")]
    public string? DefectType { get; set; }

    /// <summary>
    /// ID of the defect.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// Signifies if this defect is resolved.
    /// </summary>
    [JsonPropertyName("isResolved")]
    public required bool IsResolved { get; set; }

    /// <summary>
    /// The mechanics notes on the defect.
    /// </summary>
    [JsonPropertyName("mechanicNotes")]
    public string? MechanicNotes { get; set; }

    /// <summary>
    /// Time when mechanic notes were last updated. UTC timestamp in RFC 3339 format. Example: `2020-01-27T07:06:25Z`.
    /// </summary>
    [JsonPropertyName("mechanicNotesUpdatedAtTime")]
    public string? MechanicNotesUpdatedAtTime { get; set; }

    /// <summary>
    /// Time when this defect was resolved. Will not be returned if the defect is unresolved. UTC timestamp in RFC 3339 format. Example: `2020-01-27T07:06:25Z`.
    /// </summary>
    [JsonPropertyName("resolvedAtTime")]
    public string? ResolvedAtTime { get; set; }

    [JsonPropertyName("resolvedBy")]
    public DefectResolvedBy? ResolvedBy { get; set; }

    [JsonPropertyName("trailer")]
    public DvirTrailerDefectsItemsTrailer? Trailer { get; set; }

    [JsonPropertyName("vehicle")]
    public DvirTrailerDefectsItemsVehicle? Vehicle { get; set; }

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
