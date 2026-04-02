using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// The value of a datetime form input field.
/// </summary>
[Serializable]
public record FormsDateTimeValueObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Calendar date in YYYY-MM-DD format in the stored field timezone. Present when type is `date` (date-only fields).
    /// </summary>
    [JsonPropertyName("dateValue")]
    public DateOnly? DateValue { get; set; }

    /// <summary>
    /// The type of datetime format.  Valid values: `datetime`, `date`, `time`
    /// </summary>
    [JsonPropertyName("type")]
    public required FormsDateTimeValueObjectResponseBodyType Type { get; set; }

    /// <summary>
    /// UTC timestamp in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("value")]
    public required DateTime Value { get; set; }

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
