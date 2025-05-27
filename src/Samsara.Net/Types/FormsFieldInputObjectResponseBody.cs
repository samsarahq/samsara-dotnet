using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Forms input field object.
/// </summary>
public record FormsFieldInputObjectResponseBody
{
    [JsonPropertyName("assetValue")]
    public FormsAssetValueObjectResponseBody? AssetValue { get; set; }

    [JsonPropertyName("checkBoxesValue")]
    public FormsCheckBoxesValueObjectResponseBody? CheckBoxesValue { get; set; }

    [JsonPropertyName("dateTimeValue")]
    public FormsDateTimeValueObjectResponseBody? DateTimeValue { get; set; }

    /// <summary>
    /// ID of the forms input field object.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("issue")]
    public FormsIssueCreatedByFieldObjectResponseBody? Issue { get; set; }

    /// <summary>
    /// Forms input field label.
    /// </summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>
    /// List of forms media record objects.
    /// </summary>
    [JsonPropertyName("mediaList")]
    public IEnumerable<FormsMediaRecordObjectResponseBody>? MediaList { get; set; }

    [JsonPropertyName("mediaValue")]
    public FormsMediaValueObjectResponseBody? MediaValue { get; set; }

    [JsonPropertyName("multipleChoiceValue")]
    public FormsMultipleChoiceValueObjectResponseBody? MultipleChoiceValue { get; set; }

    /// <summary>
    /// A note attached to the field input.
    /// </summary>
    [JsonPropertyName("note")]
    public string? Note { get; set; }

    [JsonPropertyName("numberValue")]
    public FormsNumberValueObjectResponseBody? NumberValue { get; set; }

    [JsonPropertyName("personValue")]
    public FormsPersonValueObjectResponseBody? PersonValue { get; set; }

    [JsonPropertyName("signatureValue")]
    public FormsSignatureValueObjectResponseBody? SignatureValue { get; set; }

    [JsonPropertyName("tableValue")]
    public FormsTableValueObjectResponseBody? TableValue { get; set; }

    [JsonPropertyName("textValue")]
    public FormsTextValueObjectResponseBody? TextValue { get; set; }

    /// <summary>
    /// Type of the field.  Valid values: `number, text, multiple_choice, check_boxes, datetime, signature, media, asset, table`
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } =
        "number, text, multiple_choice, check_boxes, datetime, signature, media, asset, table";

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
