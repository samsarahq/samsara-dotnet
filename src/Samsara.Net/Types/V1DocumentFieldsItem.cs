using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record V1DocumentFieldsItem
{
    /// <summary>
    /// The value of a barcode scanning field. Only present for barcode scanning fields
    /// </summary>
    [JsonPropertyName("barcodeValue")]
    public IEnumerable<V1DocumentFieldsItemBarcodeValueItem>? BarcodeValue { get; set; }

    /// <summary>
    /// The value of a date time field. Only present for date time fields.
    /// </summary>
    [JsonPropertyName("dateTimeValue")]
    public V1DocumentFieldsItemDateTimeValue? DateTimeValue { get; set; }

    /// <summary>
    /// The name of a field.
    /// </summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>
    /// The value of a multiple choice field. Only present for multiple choice fields.
    /// </summary>
    [JsonPropertyName("multipleChoiceValue")]
    public IEnumerable<V1DocumentFieldsItemMultipleChoiceValueItem>? MultipleChoiceValue { get; set; }

    /// <summary>
    /// The value of a number field. Only present for number fields.
    /// </summary>
    [JsonPropertyName("numberValue")]
    public float? NumberValue { get; set; }

    /// <summary>
    /// The value of a photo or document scanning field. Only present for photo or document scanning fields.
    /// </summary>
    [JsonPropertyName("photoValue")]
    public IEnumerable<V1DocumentFieldsItemPhotoValueItem>? PhotoValue { get; set; }

    /// <summary>
    /// The value of a signature field. Only present for signature fields.
    /// </summary>
    [JsonPropertyName("signatureValue")]
    public V1DocumentFieldsItemSignatureValue? SignatureValue { get; set; }

    /// <summary>
    /// The value of a string field. Only present for string fields.
    /// </summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>
    /// The value of a field. Type varies by field type.
    /// </summary>
    [JsonPropertyName("value")]
    public object? Value { get; set; }

    /// <summary>
    /// The value type of a field.
    /// </summary>
    [JsonPropertyName("valueType")]
    public string? ValueType { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
