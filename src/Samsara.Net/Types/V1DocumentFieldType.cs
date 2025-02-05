using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record V1DocumentFieldType
{
    /// <summary>
    /// Name of this field type.
    /// </summary>
    [JsonPropertyName("label")]
    public required string Label { get; set; }

    [JsonPropertyName("multipleChoiceValueTypeMetadata")]
    public V1DocumentFieldTypeMultipleChoiceValueTypeMetadata? MultipleChoiceValueTypeMetadata { get; set; }

    [JsonPropertyName("numberValueTypeMetadata")]
    public V1DocumentFieldTypeNumberValueTypeMetadata? NumberValueTypeMetadata { get; set; }

    [JsonPropertyName("signatureValueTypeMetadata")]
    public V1DocumentFieldTypeSignatureValueTypeMetadata? SignatureValueTypeMetadata { get; set; }

    /// <summary>
    /// The type of value this field can have.
    /// Valid values: `ValueType_Number`, `ValueType_String`, `ValueType_Photo`, `ValueType_MultipleChoice`, `ValueType_Signature`, `ValueType_DateTime`.
    /// </summary>
    [JsonPropertyName("valueType")]
    public required string ValueType { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
