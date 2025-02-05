using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record FieldTypesObjectResponseBody
{
    /// <summary>
    /// The type of value this field can have.  Valid values: `photo`, `string`, `number`, `multipleChoice`, `signature`, `dateTime`, `scannedDocument`, `barcode`
    /// </summary>
    [JsonPropertyName("fieldType")]
    public required FieldTypesObjectResponseBodyFieldType FieldType { get; set; }

    /// <summary>
    /// The name of the field type.
    /// </summary>
    [JsonPropertyName("label")]
    public required string Label { get; set; }

    /// <summary>
    /// A list of the multiple choice field option labels.
    /// </summary>
    [JsonPropertyName("multipleChoiceFieldTypeMetaData")]
    public IEnumerable<MultipleChoiceFieldTypeMetaDataObjectResponseBody>? MultipleChoiceFieldTypeMetaData { get; set; }

    [JsonPropertyName("numberFieldTypeMetaData")]
    public NumberFieldTypeMetaDataObjectResponseBody? NumberFieldTypeMetaData { get; set; }

    /// <summary>
    /// The indicator that states if the field is required.
    /// </summary>
    [JsonPropertyName("requiredField")]
    public required bool RequiredField { get; set; }

    [JsonPropertyName("signatureFieldTypeMetaData")]
    public SignatureFieldTypeMetaDataObjectResponseBody? SignatureFieldTypeMetaData { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
