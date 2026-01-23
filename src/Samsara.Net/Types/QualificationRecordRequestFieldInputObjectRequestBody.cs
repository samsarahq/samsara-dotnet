using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Qualification input field request body object.
/// </summary>
[Serializable]
public record QualificationRecordRequestFieldInputObjectRequestBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("checkBoxesValue")]
    public FormSubmissionRequestCheckBoxesValueObjectRequestBody? CheckBoxesValue { get; set; }

    [JsonPropertyName("dateTimeValue")]
    public FormSubmissionRequestDateTimeValueObjectRequestBody? DateTimeValue { get; set; }

    /// <summary>
    /// ID of the qualification input field object.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("mediaValue")]
    public FormSubmissionRequestMediaValueObjectRequestBody? MediaValue { get; set; }

    [JsonPropertyName("multipleChoiceValue")]
    public FormSubmissionRequestMultipleChoiceValueObjectRequestBody? MultipleChoiceValue { get; set; }

    [JsonPropertyName("numberValue")]
    public FormSubmissionRequestNumberValueObjectRequestBody? NumberValue { get; set; }

    [JsonPropertyName("signatureValue")]
    public FormSubmissionRequestSignatureValueObjectRequestBody? SignatureValue { get; set; }

    [JsonPropertyName("tableValue")]
    public FormSubmissionRequestTableValueObjectRequestBody? TableValue { get; set; }

    [JsonPropertyName("textValue")]
    public FormSubmissionRequestTextValueObjectRequestBody? TextValue { get; set; }

    /// <summary>
    /// Type of the qualification field.  Valid values: `number`, `text`, `multiple_choice`, `check_boxes`, `datetime`, `table`, `media`, `signature`
    /// </summary>
    [JsonPropertyName("type")]
    public required QualificationRecordRequestFieldInputObjectRequestBodyType Type { get; set; }

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
