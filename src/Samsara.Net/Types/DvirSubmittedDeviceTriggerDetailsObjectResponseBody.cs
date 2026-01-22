using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Details specific to DVIR Submitted by Device
/// </summary>
[Serializable]
public record DvirSubmittedDeviceTriggerDetailsObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The trigger will only fire if the selected DVIR types are submitted within the duration.
    /// </summary>
    [JsonPropertyName("dvirMinDurationMilliseconds")]
    public long? DvirMinDurationMilliseconds { get; set; }

    /// <summary>
    /// Filter to these types of DVIR submissions.
    /// </summary>
    [JsonPropertyName("dvirSubmissionTypes")]
    public IEnumerable<DvirSubmittedDeviceTriggerDetailsObjectResponseBodyDvirSubmissionTypesItem>? DvirSubmissionTypes { get; set; }

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
