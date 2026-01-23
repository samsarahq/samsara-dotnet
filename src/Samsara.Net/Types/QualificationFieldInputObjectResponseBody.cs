using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Qualification input field object.
/// </summary>
[Serializable]
public record QualificationFieldInputObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("checkBoxesValue")]
    public FormsCheckBoxesValueObjectResponseBody? CheckBoxesValue { get; set; }

    [JsonPropertyName("dateTimeValue")]
    public FormsDateTimeValueObjectResponseBody? DateTimeValue { get; set; }

    /// <summary>
    /// ID of the qualification input field object.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// Qualification input field label.
    /// </summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>
    /// List of qualification media record objects.
    /// </summary>
    [JsonPropertyName("mediaList")]
    public IEnumerable<FormsMediaRecordObjectResponseBody>? MediaList { get; set; }

    [JsonPropertyName("multipleChoiceValue")]
    public FormsMultipleChoiceValueObjectResponseBody? MultipleChoiceValue { get; set; }

    [JsonPropertyName("numberValue")]
    public FormsNumberValueObjectResponseBody? NumberValue { get; set; }

    [JsonPropertyName("signatureValue")]
    public FormsSignatureValueObjectResponseBody? SignatureValue { get; set; }

    [JsonPropertyName("tableValue")]
    public FormsTableValueObjectResponseBody? TableValue { get; set; }

    [JsonPropertyName("textValue")]
    public FormsTextValueObjectResponseBody? TextValue { get; set; }

    /// <summary>
    /// Type of the qualification field.  Valid values: `number`, `text`, `multiple_choice`, `check_boxes`, `datetime`, `signature`, `media`, `table`
    /// </summary>
    [JsonPropertyName("type")]
    public required QualificationFieldInputObjectResponseBodyType Type { get; set; }

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
