using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[Serializable]
public record ConditionalFieldSectionObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The index of the first conditional field associated with the triggeringFieldValue in the fieldTypes list.
    /// </summary>
    [JsonPropertyName("conditionalFieldFirstIndex")]
    public long? ConditionalFieldFirstIndex { get; set; }

    /// <summary>
    /// The index of the last conditional field associated with the triggeringFieldValue in the fieldTypes list.
    /// </summary>
    [JsonPropertyName("conditionalFieldLastIndex")]
    public long? ConditionalFieldLastIndex { get; set; }

    /// <summary>
    /// The index of the multiple choice field in the fieldTypes list that triggers one or more conditional fields.
    /// </summary>
    [JsonPropertyName("triggeringFieldIndex")]
    public long? TriggeringFieldIndex { get; set; }

    /// <summary>
    /// The multiple choice option value that triggers the conditional fields.
    /// </summary>
    [JsonPropertyName("triggeringFieldValue")]
    public string? TriggeringFieldValue { get; set; }

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
