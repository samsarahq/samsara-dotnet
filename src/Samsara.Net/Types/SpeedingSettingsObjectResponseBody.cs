using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

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

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
