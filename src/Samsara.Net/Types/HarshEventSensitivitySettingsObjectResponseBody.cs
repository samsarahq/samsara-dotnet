using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// The configurable sensitivity for Harsh Event Detection on CM11/CM12/CM22 devices. Sensitivity can be measured as a numeric g-force value or the following values: `Normal`, `Less Sensitive`, `More Sensitive`.
/// </summary>
public record HarshEventSensitivitySettingsObjectResponseBody
{
    [JsonPropertyName("harshAccelSensitivityGForce")]
    public HarshAccelSensitivityGForceSettingsObjectResponseBody? HarshAccelSensitivityGForce { get; set; }

    [JsonPropertyName("harshBrakeSensitivityGForce")]
    public HarshBrakeSensitivityGForceSettingsObjectResponseBody? HarshBrakeSensitivityGForce { get; set; }

    [JsonPropertyName("harshTurnSensitivityGForce")]
    public HarshTurnSensitivityGForceSettingsObjectResponseBody? HarshTurnSensitivityGForce { get; set; }

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
