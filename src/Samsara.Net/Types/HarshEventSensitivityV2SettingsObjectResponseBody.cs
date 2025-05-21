using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// The configurable sensitivity for Harsh Event Detection. Does not apply to CM11/12/22 devices.
/// </summary>
public record HarshEventSensitivityV2SettingsObjectResponseBody
{
    [JsonPropertyName("harshAccelSensitivity")]
    public HarshAccelSensitivityV2SettingsObjectResponseBody? HarshAccelSensitivity { get; set; }

    [JsonPropertyName("harshBrakeSensitivity")]
    public HarshBrakeSensitivityV2SettingsObjectResponseBody? HarshBrakeSensitivity { get; set; }

    [JsonPropertyName("harshTurnSensitivity")]
    public HarshTurnSensitivityV2SettingsObjectResponseBody? HarshTurnSensitivity { get; set; }

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
