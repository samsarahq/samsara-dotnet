using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record V1Document
{
    [JsonPropertyName("conditionalFieldSections")]
    public IEnumerable<V1DocumentConditionalFieldsItem>? ConditionalFieldSections { get; set; }

    /// <summary>
    /// Name of the document type.
    /// </summary>
    [JsonPropertyName("documentType")]
    public required string DocumentType { get; set; }

    /// <summary>
    /// The time in Unix epoch milliseconds that the document was created in the driver app.
    /// </summary>
    [JsonPropertyName("driverCreatedAtMs")]
    public required long DriverCreatedAtMs { get; set; }

    /// <summary>
    /// ID of the driver for whom the document is submitted.
    /// </summary>
    [JsonPropertyName("driverId")]
    public required long DriverId { get; set; }

    [JsonPropertyName("fields")]
    public IEnumerable<V1DocumentFieldsItem> Fields { get; set; } =
        new List<V1DocumentFieldsItem>();

    /// <summary>
    /// ID of the document.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// Organization ID that the document belongs to.
    /// </summary>
    [JsonPropertyName("orgId")]
    public required long OrgId { get; set; }

    /// <summary>
    /// The time in Unix epoch milliseconds that the document was received by the server.
    /// </summary>
    [JsonPropertyName("serverCreatedAtMs")]
    public required long ServerCreatedAtMs { get; set; }

    /// <summary>
    /// The time in Unix epoch milliseconds that the document was updated on the server.
    /// </summary>
    [JsonPropertyName("serverUpdatedAtMs")]
    public required long ServerUpdatedAtMs { get; set; }

    /// <summary>
    /// ID of the vehicle the driver was signed into when the document was submitted. Will be `null` if the document `state` is `Required`.
    /// </summary>
    [JsonPropertyName("vehicleId")]
    public required long VehicleId { get; set; }

    /// <summary>
    /// ID of the Samsara dispatch job for which the document is submitted.
    /// </summary>
    [JsonPropertyName("dispatchJobId")]
    public required long DispatchJobId { get; set; }

    /// <summary>
    /// Custom name of the document. If no custom name is given to the document, the admin dashboard and driver app will display the template name as the default document name.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Notes submitted with this document.
    /// </summary>
    [JsonPropertyName("notes")]
    public required string Notes { get; set; }

    /// <summary>
    /// The condition of the document created for the driver. Can be either `Required` or `Submitted`. If no value is specified, `state` defaults to `Required`. `Required` documents are pre-populated documents for the Driver to fill out in the Driver App and have not yet been submitted. `Submitted` documents have been submitted by the driver in the Driver App. `Archived` documents have been archived by the admin in the cloud dashboard.
    /// </summary>
    [JsonPropertyName("state")]
    public V1DocumentBaseState? State { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
