using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[Serializable]
public record DvirDefectGetDefectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Comment on the defect.
    /// </summary>
    [JsonPropertyName("comment")]
    public required string Comment { get; set; }

    /// <summary>
    /// Time when defect was created in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("createdAtTime")]
    public string? CreatedAtTime { get; set; }

    /// <summary>
    /// List of DVIR defect's photos
    /// </summary>
    [JsonPropertyName("defectPhotos")]
    public IEnumerable<DefectPhotoResponseResponseBody>? DefectPhotos { get; set; }

    /// <summary>
    /// The unique ID of the defect type.
    /// </summary>
    [JsonPropertyName("defectTypeId")]
    public string? DefectTypeId { get; set; }

    /// <summary>
    /// The unique ID of the defect's DVIR.
    /// </summary>
    [JsonPropertyName("dvirId")]
    public required string DvirId { get; set; }

    /// <summary>
    /// The unique ID of the DVIR defect.
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
    /// Time when this defect was resolved in RFC 3339 format. Will not be returned if the defect is unresolved.
    /// </summary>
    [JsonPropertyName("resolvedAtTime")]
    public string? ResolvedAtTime { get; set; }

    [JsonPropertyName("resolvedBy")]
    public DvirResolvedByObjectResponseBody? ResolvedBy { get; set; }

    [JsonPropertyName("trailer")]
    public DefectTrailerResponseResponseBody? Trailer { get; set; }

    /// <summary>
    /// Time when defect was last updated in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("updatedAtTime")]
    public string? UpdatedAtTime { get; set; }

    [JsonPropertyName("vehicle")]
    public DefectVehicleResponseResponseBody? Vehicle { get; set; }

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
