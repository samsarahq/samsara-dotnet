using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record FieldObjectValueResponseBody
{
    /// <summary>
    /// The value of a barcode scanning field. Only present for barcode scanning fields.
    /// </summary>
    [JsonPropertyName("barcodeValue")]
    public IEnumerable<BarcodeValueObjectResponseBody>? BarcodeValue { get; set; }

    [JsonPropertyName("dateTimeValue")]
    public DateTimeValueObjectResponseBody? DateTimeValue { get; set; }

    /// <summary>
    /// The value of a multiple choice field. Only present for multiple choice fields.
    /// </summary>
    [JsonPropertyName("multipleChoiceValue")]
    public IEnumerable<MultipleChoiceValueObjectResponseBody>? MultipleChoiceValue { get; set; }

    /// <summary>
    /// The value of a number field. Only present for number fields.
    /// </summary>
    [JsonPropertyName("numberValue")]
    public double? NumberValue { get; set; }

    /// <summary>
    /// The value of a photo field. Only present for photo fields.
    /// </summary>
    [JsonPropertyName("photoValue")]
    public IEnumerable<PhotoValueObjectResponseBody>? PhotoValue { get; set; }

    /// <summary>
    /// The value of a scanned document field. Only present for scanned document fields.
    /// </summary>
    [JsonPropertyName("scannedDocumentValue")]
    public IEnumerable<ScannedDocumentValueObjectResponseBody>? ScannedDocumentValue { get; set; }

    [JsonPropertyName("signatureValue")]
    public SignatureValueObjectResponseBody? SignatureValue { get; set; }

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
