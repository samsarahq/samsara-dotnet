using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Settings on when the alert should be operational.
/// </summary>
public record OperationalSettingsObjectRequestBody
{
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
