using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Details specific to DVIR Submitted by Device
/// </summary>
public record DvirSubmittedDeviceTriggerDetailsObjectRequestBody
{
    /// <summary>
    /// The trigger will only fire if the selected DVIR types are submitted within the duration.
    /// </summary>
    [JsonPropertyName("dvirMinDurationMilliseconds")]
    public long? DvirMinDurationMilliseconds { get; set; }

    /// <summary>
    /// Filter to these types of DVIR submissions.
    /// </summary>
    [JsonPropertyName("dvirSubmissionTypes")]
    public IEnumerable<DvirSubmittedDeviceTriggerDetailsObjectRequestBodyDvirSubmissionTypesItem>? DvirSubmissionTypes { get; set; }

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
