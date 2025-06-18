using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Information about a device including its identity, last known location, last connected time, and health status.
/// </summary>
public record DeviceResponseResponseBody
{
    [JsonPropertyName("asset")]
    public required DeviceAssetResponseResponseBody Asset { get; set; }

    [JsonPropertyName("health")]
    public HealthResponseResponseBody? Health { get; set; }

    /// <summary>
    /// The last time the device was connected, in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("lastConnectedTime")]
    public DateTime? LastConnectedTime { get; set; }

    [JsonPropertyName("lastKnownLocation")]
    public LastKnownLocationResponseResponseBody? LastKnownLocation { get; set; }

    /// <summary>
    /// The product model name of the device.  Valid values: `AG24`, `AG24EU`, `AG26`, `AG26EU`, `AG45`, `AG45EU`, `AG46`, `AG46EU`, `AG46P`, `AG46PEU`, `AG51`, `AG51EU`, `AG52`, `AG52EU`, `AG53`, `AG53EU`, `AT11`, `CM31`, `CM32`, `CM33`, `CM34`, `VG34`, `VG34EU`, `VG34FN`, `VG34M`, `VG54EU`, `VG54NA`, `VG55EU`, `VG55NA`
    /// </summary>
    [JsonPropertyName("model")]
    public required DeviceResponseResponseBodyModel Model { get; set; }

    /// <summary>
    /// The serial number of the device.
    /// </summary>
    [JsonPropertyName("serial")]
    public required string Serial { get; set; }

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
