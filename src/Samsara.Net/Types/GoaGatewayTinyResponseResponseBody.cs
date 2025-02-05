using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record GoaGatewayTinyResponseResponseBody
{
    /// <summary>
    /// The model of the gateway installed on the asset.  Valid values: `AG15`, `AG24`, `AG24EU`, `AG26`, `AG26EU`, `AG41`, `AG41EU`, `AG45`, `AG45EU`, `AG46`, `AG46EU`, `AG46P`, `AG46PEU`, `AG51`, `AG51EU`, `AG52`, `AG52EU`, `AG53`, `AG53EU`, `IG15`, `IG21`, `IG41`, `IG61`, `SG1`, `SG1B`, `SG1G`, `SG1G32`, `SG1x`, `VG32`, `VG33`, `VG34`, `VG34EU`, `VG34FN`, `VG34M`, `VG54ATT`, `VG54EU`, `VG54FN`, `VG54NA`, `VG54NAE`, `VG54NAH`, `VG55EU`, `VG55FN`, `VG55NA`
    /// </summary>
    [JsonPropertyName("model")]
    public required GoaGatewayTinyResponseResponseBodyModel Model { get; set; }

    /// <summary>
    /// The serial number of the gateway installed on the asset.
    /// </summary>
    [JsonPropertyName("serial")]
    public required string Serial { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
