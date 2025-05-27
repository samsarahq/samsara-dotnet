using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// A single document.
/// </summary>
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
