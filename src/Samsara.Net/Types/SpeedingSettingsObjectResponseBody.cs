using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Enables custom speeding levels.
/// </summary>
[Serializable]
public record SpeedingSettingsObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

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

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
