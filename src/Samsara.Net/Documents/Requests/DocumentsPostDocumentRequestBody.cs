using System.Text.Json.Serialization;
using Samsara.Net;
using Samsara.Net.Core;

namespace Samsara.Net.Documents;

[Serializable]
public record DocumentsPostDocumentRequestBody
{
    /// <summary>
    /// ID for the document type.
    /// </summary>
    [JsonPropertyName("documentTypeId")]
    public required string DocumentTypeId { get; set; }

    /// <summary>
    /// ID of the driver. Can be either unique Samsara ID or an [external ID](/docs/external-ids) for the driver.
    /// </summary>
    [JsonPropertyName("driverId")]
    public required string DriverId { get; set; }

    /// <summary>
    /// The fields associated with this document.
    /// </summary>
    [JsonPropertyName("fields")]
    public IEnumerable<FieldObjectPostRequestBody>? Fields { get; set; }

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

    /// <summary>
    /// ID of the route stop. Can be either unique Samsara ID or an [external ID](/docs/external-ids) for the route stop.
    /// </summary>
    [JsonPropertyName("routeStopId")]
    public string? RouteStopId { get; set; }

    /// <summary>
    /// The condition of the document created for the driver. Can be either `required` or `submitted`, if no value is specified, `state` defaults to `required`. `required` documents are pre-populated documents for the Driver to fill out in the Driver App.  Valid values: `submitted`, `required`
    /// </summary>
    [JsonPropertyName("state")]
    public DocumentsPostDocumentRequestBodyState? State { get; set; }

    /// <summary>
    /// ID of the vehicle. Can be either unique Samsara ID or an [external ID](/docs/external-ids) for the vehicle.
    /// </summary>
    [JsonPropertyName("vehicleId")]
    public string? VehicleId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
