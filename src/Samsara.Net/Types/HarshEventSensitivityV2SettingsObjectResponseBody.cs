using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record HarshEventSensitivityV2SettingsObjectResponseBody
{
    [JsonPropertyName("harshAccelSensitivity")]
    public HarshAccelSensitivityV2SettingsObjectResponseBody? HarshAccelSensitivity { get; set; }

    [JsonPropertyName("harshBrakeSensitivity")]
    public HarshBrakeSensitivityV2SettingsObjectResponseBody? HarshBrakeSensitivity { get; set; }

    [JsonPropertyName("harshTurnSensitivity")]
    public HarshTurnSensitivityV2SettingsObjectResponseBody? HarshTurnSensitivity { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
