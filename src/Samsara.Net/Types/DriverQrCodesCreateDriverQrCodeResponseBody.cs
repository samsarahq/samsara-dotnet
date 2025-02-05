using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record DriverQrCodesCreateDriverQrCodeResponseBody
{
    [JsonPropertyName("data")]
    public required QrCodeResponseObjectResponseBody Data { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
