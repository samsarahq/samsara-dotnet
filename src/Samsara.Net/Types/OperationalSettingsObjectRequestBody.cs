using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Settings on when the alert should be operational.
/// </summary>
[Serializable]
public record OperationalSettingsObjectRequestBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The type of time ranges.  Valid values: `activeBetween`, `inactiveBetween`
    /// </summary>
    [JsonPropertyName("timeRangeType")]
    public required OperationalSettingsObjectRequestBodyTimeRangeType TimeRangeType { get; set; }

    /// <summary>
    /// The time ranges this alert applies to.
    /// </summary>
    [JsonPropertyName("timeRanges")]
    public IEnumerable<TimeRangeObjectRequestBody> TimeRanges { get; set; } =
        new List<TimeRangeObjectRequestBody>();

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
