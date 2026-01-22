using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.DriverQrCodes;

[Serializable]
public record DriverQrCodesDeleteDriverQrCodeRequestBody
{
    /// <summary>
    /// Unique ID of the driver.
    /// </summary>
    [JsonPropertyName("driverId")]
    public required long DriverId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
