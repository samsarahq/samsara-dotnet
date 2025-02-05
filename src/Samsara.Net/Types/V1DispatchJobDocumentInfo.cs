using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record V1DispatchJobDocumentInfo
{
    /// <summary>
    /// ID of driver that submitted the document.
    /// </summary>
    [JsonPropertyName("driverId")]
    public required int DriverId { get; set; }

    /// <summary>
    /// ID of document. This can be used to query for the document's info via the /v1/fleet/drivers/{driver_id}/documents/{document_id} endpoint
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
