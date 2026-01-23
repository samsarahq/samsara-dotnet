using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// The value of a cell in a table row.
/// </summary>
[Serializable]
public record FormSubmissionRequestTableCellObjectRequestBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("checkBoxesValue")]
    public FormSubmissionRequestCheckBoxesValueObjectRequestBody? CheckBoxesValue { get; set; }

    [JsonPropertyName("dateTimeValue")]
    public FormSubmissionRequestDateTimeValueObjectRequestBody? DateTimeValue { get; set; }

    /// <summary>
    /// Unique identifier for the cell.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("multipleChoiceValue")]
    public FormSubmissionRequestMultipleChoiceValueObjectRequestBody? MultipleChoiceValue { get; set; }

    [JsonPropertyName("numberValue")]
    public FormSubmissionRequestNumberValueObjectRequestBody? NumberValue { get; set; }

    [JsonPropertyName("personValue")]
    public FormSubmissionRequestPersonValueObjectRequestBody? PersonValue { get; set; }

    [JsonPropertyName("textValue")]
    public FormSubmissionRequestTextValueObjectRequestBody? TextValue { get; set; }

    /// <summary>
    /// Type of the cell field.  Valid values: `number`, `text`, `multiple_choice`, `check_boxes`, `datetime`, `person`
    /// </summary>
    [JsonPropertyName("type")]
    public required FormSubmissionRequestTableCellObjectRequestBodyType Type { get; set; }

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
