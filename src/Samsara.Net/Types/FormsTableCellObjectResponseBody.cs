using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record FormsTableCellObjectResponseBody
{
    [JsonPropertyName("checkBoxesValue")]
    public FormsCheckBoxesValueObjectResponseBody? CheckBoxesValue { get; set; }

    [JsonPropertyName("dateTimeValue")]
    public FormsDateTimeValueObjectResponseBody? DateTimeValue { get; set; }

    /// <summary>
    /// Unique identifier for the cell.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("mediaValue")]
    public FormsMediaValueObjectResponseBody? MediaValue { get; set; }

    [JsonPropertyName("multipleChoiceValue")]
    public FormsMultipleChoiceValueObjectResponseBody? MultipleChoiceValue { get; set; }

    [JsonPropertyName("numberValue")]
    public FormsNumberValueObjectResponseBody? NumberValue { get; set; }

    [JsonPropertyName("personValue")]
    public FormsPersonValueObjectResponseBody? PersonValue { get; set; }

    [JsonPropertyName("signatureValue")]
    public FormsSignatureValueObjectResponseBody? SignatureValue { get; set; }

    [JsonPropertyName("textValue")]
    public FormsTextValueObjectResponseBody? TextValue { get; set; }

    /// <summary>
    /// Type of the cell field.  Valid values: `number, text, multiple_choice, check_boxes, datetime, signature, media, person`
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
