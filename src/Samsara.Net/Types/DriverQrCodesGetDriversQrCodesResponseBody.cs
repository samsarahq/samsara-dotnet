using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record DriverQrCodesGetDriversQrCodesResponseBody
{
    /// <summary>
    /// List of driver QR codes.
    /// </summary>
    [JsonPropertyName("data")]
    public IEnumerable<QrCodeResponseObjectResponseBody> Data { get; set; } =
        new List<QrCodeResponseObjectResponseBody>();

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
