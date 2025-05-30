using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Status of engine lights on J1939 vehicles.
/// </summary>
public record VehicleStatsFaultCodesValueJ1939CheckEngineLights
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
