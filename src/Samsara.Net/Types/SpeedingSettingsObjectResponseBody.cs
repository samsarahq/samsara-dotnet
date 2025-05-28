using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Enables custom speeding levels.
/// </summary>
public record SpeedingSettingsObjectResponseBody
{
    /// <summary>
    /// The speeding severity levels for an organization.
    /// </summary>
    [JsonPropertyName("severityLevels")]
    public IEnumerable<SpeedingSeverityLevelResponseBody>? SeverityLevels { get; set; }

    /// <summary>
    /// The unit of measurement for speeding  Valid values: `milesPerHour`, `kilometersPerHour`, `percentage`
    /// </summary>
    [JsonPropertyName("unit")]
    public SpeedingSettingsObjectResponseBodyUnit? Unit { get; set; }

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
