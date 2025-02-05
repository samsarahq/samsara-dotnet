using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record HarshEventSensitivitySettingsObjectResponseBody
{
    [JsonPropertyName("harshAccelSensitivityGForce")]
    public HarshAccelSensitivityGForceSettingsObjectResponseBody? HarshAccelSensitivityGForce { get; set; }

    [JsonPropertyName("harshBrakeSensitivityGForce")]
    public HarshBrakeSensitivityGForceSettingsObjectResponseBody? HarshBrakeSensitivityGForce { get; set; }

    [JsonPropertyName("harshTurnSensitivityGForce")]
    public HarshTurnSensitivityGForceSettingsObjectResponseBody? HarshTurnSensitivityGForce { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
