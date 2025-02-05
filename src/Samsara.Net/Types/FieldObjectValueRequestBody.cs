using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record FieldObjectValueRequestBody
{
    /// <summary>
    /// The value of a barcode scanning field. Only present for barcode scanning fields.
    /// </summary>
    [JsonPropertyName("barcodeValue")]
    public IEnumerable<BarcodeValueObjectRequestBody>? BarcodeValue { get; set; }

    [JsonPropertyName("dateTimeValue")]
    public DateTimeValueObjectRequestBody? DateTimeValue { get; set; }

    /// <summary>
    /// The value of a multiple choice field. Only present for multiple choice fields.
    /// </summary>
    [JsonPropertyName("multipleChoiceValue")]
    public IEnumerable<MultipleChoiceValueObjectRequestBody>? MultipleChoiceValue { get; set; }

    /// <summary>
    /// The value of a number field. Only present for number fields.
    /// </summary>
    [JsonPropertyName("numberValue")]
    public double? NumberValue { get; set; }

    /// <summary>
    /// The value of a photo field. Only present for photo fields.
    /// </summary>
    [JsonPropertyName("photoValue")]
    public IEnumerable<PhotoValueObjectRequestBody>? PhotoValue { get; set; }

    /// <summary>
    /// The value of a scanned document field. Only present for scanned document fields.
    /// </summary>
    [JsonPropertyName("scannedDocumentValue")]
    public IEnumerable<ScannedDocumentValueObjectRequestBody>? ScannedDocumentValue { get; set; }

    [JsonPropertyName("signatureValue")]
    public SignatureValueObjectRequestBody? SignatureValue { get; set; }

    /// <summary>
    /// The value of a string field. Only present for string fields.
    /// </summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
