using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record QrCodeResponseObjectResponseBody
{
    /// <summary>
    /// ID for the driver the QR code belongs to.
    /// </summary>
    [JsonPropertyName("driverId")]
    public required long DriverId { get; set; }

    /// <summary>
    /// URL link to the driver assignment QR code. Included if a QR code has been created for the driver.
    /// </summary>
    [JsonPropertyName("qrCodeLink")]
    public string? QrCodeLink { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
