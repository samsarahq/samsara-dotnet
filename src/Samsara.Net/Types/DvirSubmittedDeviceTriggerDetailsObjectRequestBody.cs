using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

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

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
