using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// J1939 check engine lights.
/// </summary>
public record V1VehicleMaintenanceJ1939CheckEngineLight
{
    [JsonPropertyName("emissionsIsOn")]
    public bool? EmissionsIsOn { get; set; }

    [JsonPropertyName("protectIsOn")]
    public bool? ProtectIsOn { get; set; }

    [JsonPropertyName("stopIsOn")]
    public bool? StopIsOn { get; set; }

    [JsonPropertyName("warningIsOn")]
    public bool? WarningIsOn { get; set; }

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
