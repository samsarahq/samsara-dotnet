using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Dismissal reason. Required when eventState is `dismissed`. Must not be provided for other states.
/// </summary>
[Serializable]
public record PatchSafetyEventsDismissalReasonBodyRequestBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The dismissal reason code associated with the event.  Valid values: `incorrect`, `minorEvent`, `other`
    /// </summary>
    [JsonPropertyName("code")]
    public required PatchSafetyEventsDismissalReasonBodyRequestBodyCode Code { get; set; }

    /// <summary>
    /// The dismissal reason comment associated with the event.
    /// </summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

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
