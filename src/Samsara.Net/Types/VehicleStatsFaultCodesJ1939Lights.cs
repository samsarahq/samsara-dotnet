using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record VehicleStatsFaultCodesJ1939Lights
{
    /// <summary>
    /// True if the MIL status is nonzero.
    /// </summary>
    [JsonPropertyName("emissionsIsOn")]
    public required bool EmissionsIsOn { get; set; }

    /// <summary>
    /// True if the engine protect lamp status is nonzero.
    /// </summary>
    [JsonPropertyName("protectIsOn")]
    public required bool ProtectIsOn { get; set; }

    /// <summary>
    /// True if the red lamp status is nonzero.
    /// </summary>
    [JsonPropertyName("stopIsOn")]
    public required bool StopIsOn { get; set; }

    /// <summary>
    /// True if the amber lamp status is nonzero.
    /// </summary>
    [JsonPropertyName("warningIsOn")]
    public required bool WarningIsOn { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
