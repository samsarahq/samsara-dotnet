using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// A single document.
/// </summary>
public record DocumentResponseObjectResponseBody
{
    /// <summary>
    /// List of the document conditional field sections.
    /// </summary>
    [JsonPropertyName("conditionalFieldSections")]
    public IEnumerable<ConditionalFieldSectionObjectResponseBody>? ConditionalFieldSections { get; set; }

    /// <summary>
    /// Time the document was created in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("createdAtTime")]
    public required DateTime CreatedAtTime { get; set; }

    [JsonPropertyName("documentType")]
    public required GoaDocumentTypeTinyResponseResponseBody DocumentType { get; set; }

    [JsonPropertyName("driver")]
    public required GoaDriverTinyResponseResponseBody Driver { get; set; }

    /// <summary>
    /// The fields associated with this document.
    /// </summary>
    [JsonPropertyName("fields")]
    public IEnumerable<FieldObjectResponseBody> Fields { get; set; } =
        new List<FieldObjectResponseBody>();

    /// <summary>
    /// Universally unique identifier for the document.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// Name of the document.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Notes on the document.
    /// </summary>
    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    [JsonPropertyName("route")]
    public GoaRouteTinyResponseResponseBody? Route { get; set; }

    [JsonPropertyName("routeStop")]
    public GoaRouteStopTinyResponseResponseBody? RouteStop { get; set; }

    /// <summary>
    /// The condition of the document created for the driver. Can be either Required or Submitted. Required documents are pre-populated documents for the Driver to fill out in the Driver App and have not yet been submitted. Submitted documents have been submitted by the driver in the Driver App. Archived documents have been archived by the admin in the cloud dashboard.  Valid values: `submitted`, `required`, `archived`
    /// </summary>
    [JsonPropertyName("state")]
    public required DocumentResponseObjectResponseBodyState State { get; set; }

    /// <summary>
    /// Time the document was updated in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("updatedAtTime")]
    public DateTime? UpdatedAtTime { get; set; }

    [JsonPropertyName("vehicle")]
    public GoaVehicleTinyResponseResponseBody? Vehicle { get; set; }

    /// <summary>
    /// Additional properties received from the response, if any.
    /// </summary>
    /// <remarks>
    /// [EXPERIMENTAL] This API is experimental and may change in future releases.
    /// </remarks>
    [JsonExtensionData]
    public IDictionary<string, JsonElement> AdditionalProperties { get; internal set; } =
        new Dictionary<string, JsonElement>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
